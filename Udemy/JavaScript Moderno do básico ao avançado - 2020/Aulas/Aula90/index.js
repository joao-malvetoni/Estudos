function Produto(nome, preco, estoque){
    //this.nome = nome;
    //this.preco = preco;
    //this.estoque = estoque;

    Object.defineProperty(this, 'estoque', {
        enumerable: true, // mostra a chave (propriedade) ou não
        value: estoque, // valor da propriedade (pode ser dado ou função, ...)
        writable: false, // pode alterar ou não
        configurable: false // pode reconfigurar a chave ou não (apagar, ...)
    });

    Object.defineProperties(this, {
        nome: {
            enumerable: true, 
            value: nome, 
            writable: true, 
            configurable: true 
        },
        preco: {
            enumerable: true, 
            value: preco, 
            writable: true, 
            configurable: true 
        }
    });
}

function Produto2(nome, preco, estoque){
    Object.defineProperty(this, 'estoque', {
        enumerable: true, 
        configurable: true,
        get: function(){
            return estoque;
        },
        set: function(valor){

            if(typeof valor !== 'number')
                throw new TypeError("Valor inválido para estoque");

            estoque = valor;
        }
    });
}

function criaProduto(nome) {
    return {
        get nome() {
            return nome;
        },
        set nome(valor){
            nome = valor;
        }
    };
}

const p1 = new Produto("Camiseta", 20, 3);
console.log(p1);
console.log(Object.keys(p1));

const p2 = new Produto2("Camiseta", 20, 3);
console.log(p2.estoque);

const p3 = criaProduto("Camiseta");
console.log(p3.nome);