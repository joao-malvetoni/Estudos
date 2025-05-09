// Criação básica de função

function saudacao(nome) {
  return `Bom dia ${nome}!`;
}

function soma(x = 1, y = 1) {
  const resultado = x + y;
  return resultado;
}

const variavel = saudacao("João Pedro");

console.log(variavel);
console.log(soma(2, 2));
console.log(soma());

// Funções anônimmas

const raiz = function (n) {
  return n ** 0.5;
};

console.log(raiz(9));

// Arrow function
const raiz2 = (n) => {
    return n ** 0.5;
};

// Resumindo a função acima teríamos
// const raiz2 = n => n ** 0.5;

console.log(raiz2(9));