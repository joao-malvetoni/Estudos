using Microsoft.AspNetCore.SignalR;
using RealPromo.ApiWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealPromo.ApiWeb.Hubs
{
    //RPC
    public class PromoHub : Hub
    {
        /*
         * Cliente - JS/c#/Java
         * Cliente(JS) -> Hub(C#) (C# - CadastrarPromocao)
         * Hub(C#) -> Cliente(JS) (JS - ReceberPromocao)
         */
        public async Task CadastrarPromocao(Promocao promocao)
        {
            /*
             * Banco
             * Queue/Scheduler.....
             * Notificar o usuário (Signal R)
             */
            await Clients.Caller.SendAsync("CadastradoSucesso"); // Notificar o Caller -> Cadastro realizado com sucesso.
            await Clients.Others.SendAsync("ReceberPromocao", promocao); // Notificar Promoção Chegou.
        }
    }
}
