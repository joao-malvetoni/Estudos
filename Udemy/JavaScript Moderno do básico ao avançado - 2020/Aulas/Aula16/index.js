//            0123
//const nome = "João";
//console.log(nome[0]);

//              0      1        2
let alunos = ['Luíz', 'Maria', 'João']
console.log(alunos[0]);
alunos[0] = "Eduardo";
console.log(alunos[0]);
alunos[3] = "Luíza";
console.log(alunos[3]);
console.log(alunos.length);

alunos.push("Pedro"); // Adiciona no fim do array
alunos.unshift("Márcia"); // Adiciona no início do array
alunos.pop() // Remove no fim do array
alunos.shift() // Remove no ínicio do array

// Remove o item, porém não altera o índice do array
delete alunos[1];
console.log(alunos);

//Acessar valor que não existe
console.log(alunos[50]);

console.log(typeof alunos); // Array também é um Object
console.log(alunos instanceof Array);
