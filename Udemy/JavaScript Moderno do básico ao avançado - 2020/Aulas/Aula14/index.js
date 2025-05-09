let num1 = 1500; // number
let num2 = 2.5; // number

console.log(num1 + num2); // Soma
console.log(num1.toString() + num2); // Concatenação
console.log(num1.toString(2)); // Número em binário
console.log(num1.toFixed(2)); // Número de casas decimais, arredondando para o valor mais próximo
console.log(Number.isInteger(num1)); // Verifica se o número é inteiro
console.log(Number.isNaN(num1)); // Verifica se o valor é NaN (Not a Number)

// IEEE 754-2008 - Padrão que o JS usa para a precisão.
let num3 = 0.7;
let num4 = 0.1;

console.log(num3 + num4);

num3 += num4;
num3 += num4;
num3 += num4;
//num3 = (num3 * 100) + (num4 * 100) / 100; // Corrige

console.log(num3);
num3 = num3.toFixed(2); // Não corrige
//num3 = parseFloat(num3.toFixed(2)); // Corrige
//num3 = Number(num3.toFixed(2)); // Corrige
console.log(num3);
console.log(Number.isInteger(num3));