using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZapWeb.Database;
using ZapWeb.Models;

namespace ZapWeb.Hubs
{
    public class ZapWebHub : Hub
    {
        private BancoContext _banco;
        public ZapWebHub(BancoContext banco)
        {
            _banco = banco;
        }

        public async Task Cadastrar(Usuario usuario)
        {
            bool IsExistUser = _banco.Usuarios.Where(a => a.Email == usuario.Email).Count() > 0;

            if (IsExistUser)
            {
                await Clients.Caller.SendAsync("ReceberCadastro", false, null, "E-mail já cadastrado");
            }
            else
            {
                _banco.Usuarios.Add(usuario);
                _banco.SaveChanges();

                await Clients.Caller.SendAsync("ReceberCadastro", true, usuario, "Usuário cadastrado com sucesso!");
            }
        }

        public async Task Login(Usuario usuario)
        {
            var usuarioDB = _banco.Usuarios.FirstOrDefault(a => a.Email == usuario.Email && a.Senha == usuario.Senha);

            if(usuarioDB == null)
            {
                await Clients.Caller.SendAsync("ReceberLogin", false, null, "E-mail ou senha incorretos!");
            }
            else
            {
                await Clients.Caller.SendAsync("ReceberLogin", true, usuarioDB, null);
                usuarioDB.IsOnline = true;
                _banco.Usuarios.Update(usuarioDB);
                _banco.SaveChanges();

                await NotificarMudancaNaListaUsuarios();
            }
        }

        public async Task Logout(Usuario usuario)
        {
            var usuarioDB = _banco.Usuarios.Find(usuario.ID);
            usuarioDB.IsOnline = false;
            _banco.Usuarios.Update(usuarioDB);
            _banco.SaveChanges();
            await DelConnectionIDDoUsuario(usuarioDB);
            await NotificarMudancaNaListaUsuarios();
        }

        public async Task AddConnectionIDDoUsuario(Usuario usuario)
        {
            var connectionIDCurrent = Context.ConnectionId;
            List<string> connectionsID = null;

            Usuario usuarioDB = _banco.Usuarios.Find(usuario.ID);
            if(usuarioDB.ConnectionID == null)
            {
                connectionsID = new List<string>();
                connectionsID.Add(connectionIDCurrent);
            }
            else
            {
                connectionsID = JsonConvert.DeserializeObject<List<string>>(usuarioDB.ConnectionID);
                if (!connectionsID.Contains(connectionIDCurrent))
                {
                    connectionsID.Add(connectionIDCurrent);
                }
            }

            usuarioDB.IsOnline = true;
            usuarioDB.ConnectionID = JsonConvert.SerializeObject(connectionsID);
            _banco.Usuarios.Update(usuarioDB);
            _banco.SaveChanges();
            await NotificarMudancaNaListaUsuarios();

            //Adicionar connectionsID  aos grupos do SignalR
            var grupos = _banco.Grupos.Where(a => a.Usuarios.Contains(usuarioDB.Email));
            foreach (var connectionID in connectionsID)
            {
                foreach (var grupo in grupos)
                {
                    await Groups.AddToGroupAsync(connectionID, grupo.Nome);
                }
            }
        }

        public async Task DelConnectionIDDoUsuario(Usuario usuario)
        {
            List<string> connectionsID = null;
            Usuario usuarioDB = _banco.Usuarios.Find(usuario.ID);
            if (usuarioDB.ConnectionID.Length > 0)
            {
                var connectionIDCurrent = Context.ConnectionId;
                connectionsID = JsonConvert.DeserializeObject<List<string>>(usuarioDB.ConnectionID);
                if (connectionsID.Contains(connectionIDCurrent))
                {
                    connectionsID.Remove(connectionIDCurrent);
                }

                usuarioDB.ConnectionID = JsonConvert.SerializeObject(connectionsID);

                if (connectionsID.Count <= 0)
                {
                    usuarioDB.IsOnline = false;
                }

                _banco.Usuarios.Update(usuarioDB);
                _banco.SaveChanges();
                await NotificarMudancaNaListaUsuarios();

                // Remoção da ConnectionID dos grupos de conversa desse usuário no SignalR.
                var grupos = _banco.Grupos.Where(a => a.Usuarios.Contains(usuarioDB.Email));
                foreach (var connectionID in connectionsID)
                {
                    foreach (var grupo in grupos)
                    {
                        await Groups.RemoveFromGroupAsync(connectionID, grupo.Nome);
                    }
                }
            }
        }

        public async Task ObterListaUsuarios()
        {
            List<Usuario> usuarios = _banco.Usuarios.ToList();

            await Clients.Caller.SendAsync("ReceberListaUsuarios", usuarios);
        }

        public async Task NotificarMudancaNaListaUsuarios()
        {
            await Clients.All.SendAsync("ReceberListaUsuarios", _banco.Usuarios.ToList());
        }

        /*
         * SignalR - Grupos tem que terum id único
         */
        public async Task CriarOuAbrirGrupo(string emailUserUm, string emailUserDois)
        {
            string NomeGrupo = CriarNomeGrupo(emailUserUm, emailUserDois);

            Grupo grupo = _banco.Grupos.FirstOrDefault(a => a.Nome == NomeGrupo);
            if(grupo == null)
            {
                //Criar Grupo no banco

                grupo = new Grupo();
                grupo.Nome = NomeGrupo;
                grupo.Usuarios = JsonConvert.SerializeObject(new List<string>()
                {
                    emailUserUm, emailUserDois
                });

                _banco.Grupos.Add(grupo);
                _banco.SaveChanges();
            }

            //Adicionou as connections ids para o grupo do SignalR
            List<string> emails = JsonConvert.DeserializeObject<List<string>>(grupo.Usuarios);

            Usuario usuarioUm = _banco.Usuarios.First(a => a.Email == emails[0]);
            Usuario usuarioDois = _banco.Usuarios.First(a => a.Email == emails[1]);
            List<Usuario> usuarios = new List<Usuario>() { usuarioUm, usuarioDois };

            foreach (var usuario in usuarios)
            {
                var connectionsID = JsonConvert.DeserializeObject<List<string>>(usuario.ConnectionID);
                foreach (var connectionID in connectionsID)
                {
                    await Groups.AddToGroupAsync(connectionID, NomeGrupo);
                }
            }

            List<Mensagem> mensagens = _banco.Mensagens.Where(a => a.NomeGrupo == NomeGrupo).OrderBy(a=>a.DataCriacao).ToList();
            for (int i = 0; i < mensagens.Count; i++)
            {
                mensagens[i].Usuario = JsonConvert.DeserializeObject<Usuario>(mensagens[i].UsuarioJson);
            }
            await Clients.Caller.SendAsync("AbrirGrupo", NomeGrupo, mensagens);
        }

        public async Task EnviarMensagem(Usuario usuario, string msg, string nomeGrupo)
        {
            Grupo grupo = _banco.Grupos.FirstOrDefault(a => a.Nome == nomeGrupo);

            if (!grupo.Usuarios.Contains(usuario.Email))
            {
                throw new Exception("Usuário não pertence ao grupo");
            }

            Mensagem mensagem = new Mensagem();
            mensagem.NomeGrupo = nomeGrupo;
            mensagem.Texto = msg;
            mensagem.UsuarioId = usuario.ID;
            mensagem.UsuarioJson = JsonConvert.SerializeObject(usuario);
            mensagem.Usuario = usuario;
            mensagem.DataCriacao = DateTime.Now;

            _banco.Mensagens.Add(mensagem);
            _banco.SaveChanges();

            await Clients.Group(nomeGrupo).SendAsync("ReceberMensagem", mensagem, nomeGrupo);
        }

        private string CriarNomeGrupo(string emailUserUm, string emailUserDois)
        {
            List<String> lista = new List<string>() { emailUserUm, emailUserDois };
            var listaOrdenada = lista.OrderBy(a => a).ToList();
            StringBuilder sb = new StringBuilder();
            foreach (var item in listaOrdenada)
            {
                sb.Append(item);
            }

            return sb.ToString();
        }
    }
}
