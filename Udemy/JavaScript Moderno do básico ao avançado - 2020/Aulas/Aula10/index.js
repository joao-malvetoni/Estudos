// String
const nome = 'João';
const nome1 = "João";
const nome2 = `João`;

//Number
const num1 = 10;
const num2 = 10.52;

let nomeAluno; // undefined = não aponta para local nenhum na memória.
//(definido pela linguagem).
const sobrenomeAluno = null; // Nulo = não aponta para local nenhum na memória.
// (definido pelo programador).

// Boolean
const aprovado = true; // true | false (lógico)

/* 
 * Operadores aritméticos
 * + Adição / Concatenação
 * - / *
 */

//Adição
const num1 = 5;
const num2 = 10;
console.log(num1 + num2);

//Concatenação
const num1 = '5';
const num2 = 10;
console.log(num1 + num2);

// Multiplicação
const num1 = 5;
const num2 = 10;
console.log(num1 * num2);

// Divisão
const num1 = 5;
const num2 = 10;
console.log(num1 + num2);

// Subtração
const num1 = 5;
const num2 = 10;
console.log(num1 - num2);

// Potenciação
const num1 = 5;
const num2 = 10;
console.log(num1 ** num2);

// Módulo - Resto da divisão
const num1 = 5;
const num2 = 10;
console.log(num1 % num2);

// Incremento
let contador = 1;
contador++; // ou ++contador;
contador += 2; // contador = contador + 2
contaador *= 2; // contador = contador * 2
contaador **= 2; // contador = contador ** 2
console.log(contador);

// Decremento
let contador = 1;
contador--; // ou --contador;
contador -= 2; // contador = contador - 2
console.log(contador);
// Operadores de atribuição :> =, *=, **=, +=, -=, ...

const num1 = 10;
const num2 = "João"; // => Assim a conta não funciona
console.log(num1 * num2);
// NaN = Not A Number
// Se 'num2' fosse um número em formato texto, o JS resolveria

const num1 = 10;
const num2 = "2"; // => Assim a conta funciona
console.log(num1 * num2);

/* 
 * Obs.: Se a conta fosse de adição, 
 * o valor não daria 20, mas '102', pois seria uma concatenação.
 */
// Conversões

const num1 = 10;
const num2 = parseInt("2"); // Converte número para 2 inteiro.
// const num2 = parseInt("2.5"); 
// Resultado: 2.

const num3 = parseFloat("2.5"); 
// Converte número para 2.5 flutuante.

const num2 = Number("2"); 
// Converte o número, independente do tipo, ou retorna NaN
console.log(num1 * num2);