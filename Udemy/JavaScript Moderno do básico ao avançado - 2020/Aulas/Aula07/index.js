// Não podemos criar constantes com palavras reservadas (let, if, var, ).
// Constantes precisam ter nomes significativos.
// Não pode começar o nome de uma constante com um número.
// Não pode conter espaços ou traços. Utilizar modo CamelCase nesse caso (nomeCompletoDoCliente).
// Case-sensitive (nomeCliente != nomecliente).
// Não pode modificar o valor de uma constante.
// Não utilize VAR, utilize CONST.

// String = Text | Number = Número
const nome = 'João'; // Na criação é necessário inicializá-la.
console.log(nome);

const primeiroNumero = 5; // Number
const segundoNumero = 10;

const resultado = primeiroNumero * segundoNumero;
console.log(resultado);
const resultadoDuplicado = resultado * 2;
console.log(resultadoDuplicado);

let resultadoTriplicado = resultado * 3;
console.log(resultadoTriplicado);
resultadoTriplicado = resultadoTriplicado + 5;
console.log(resultadoTriplicado);

console.log( typeof(primeiroNumero) );
console.log( typeof primeiroNumero );