// uma função factory
function criaPessoa(nome, sobrenome, idade) {
    return {
        nome: nome,
        sobrenome: sobrenome,
        idade: idade,
        fala() {
            console.log(`${this.nome} ${this.sobrenome} está falando oi...`);
            console.log(`A minha idade atual é ${this.idade}.`);
        },
        incrementaIdade() {
            ++this.idade;
        }
    }

    /* 
    Como os valores dos parâmetros são identicos  
    aos valores das propriedades que se quer criar no objeto,
    poderíamos ter declarado assim:
    return {
        nome,
        sobrenome,
        idade
    }
    Dessa forma ele cria a propriedade e já insere o valor.
    */
}

const pessoa1 = criaPessoa("João Pedro", "Malvetoni", 21);
const pessoa2 = criaPessoa("Maria", "Oliveira",  19);

console.log(pessoa1.nome);
console.log(pessoa1.sobrenome);
console.log(pessoa1.idade);
pessoa1.fala();
pessoa1.incrementaIdade();
pessoa1.fala();