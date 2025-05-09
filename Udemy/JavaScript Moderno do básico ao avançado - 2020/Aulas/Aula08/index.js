const nome = 'João Pedro';
const sobrenome = 'Malvetoni';
const idade = 22;
const peso = 79;
const altura = 1.80;
let indiceMassaCorporal = peso / (altura * altura);
let anoNascimento = 2020 - idade;

// Usando vírgulas
console.log(nome, sobrenome, "tem", idade, "anos, pesa", peso,"kg");
console.log("tem",altura,'de altura e seu IMC é de',indiceMassaCorporal);
console.log(nome, 'nasceu em', anoNascimento);

// Usando concatenação
console.log(nome + ' ' + sobrenome + " tem " + idade + " anos, pesa " + peso + " kg");
console.log("tem " + altura + ' de altura e seu IMC é de ' + indiceMassaCorporal);
console.log(nome + ' nasceu em ' + anoNascimento);

// Usando template strings
console.log(`${nome} ${sobrenome} tem ${idade} anos, pesa ${peso} kg`);
console.log(`tem ${altura} de altura e seu IMC é de ${indiceMassaCorporal}`);
console.log(`${nome} nasceu em ${anoNascimento}`);
