let num1 = 9.54578;
let num2 = Math.floor(num1); // Arredonda para baixo
console.log(num2);
num2 = Math.ceil(num1); // Arredonda para cima
console.log(num2);
num2 = Math.round(num1); // Arredonda para o mais próximo
console.log(num2);

console.log(Math.max(1,2,3,4,5,-10,-50,1500,9,8,7,6)); // Pega o maior número da sequência
console.log(Math.min(1,2,3,4,5,-10,-50,1500,9,8,7,6)); // Pega o menor número da sequência
console.log(Math.random()); // Número aleatório

console.log(Math.random() * (10 - 5) + 5); // Número aleatório entre 10 e 5
console.log(Math.round(Math.random() * (10 - 5) + 5)); // Número inteiro aleatório entre 10 e 5

console.log(Math.PI); // número PI
console.log(Math.pow(2, 10)); // Potência

// Em outras linguagens de programação resultaria um erro
// porém nesse caso retorno um dado numérico Infinity
console.log(100 / 0); 
