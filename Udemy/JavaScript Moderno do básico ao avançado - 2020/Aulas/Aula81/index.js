const nomes = ["Eduardo", "Maria", "Joana"];

// Declaração usando construtor
const nomes2 = new Array("Eduardo", "Maria", "Joana");

// Array fica com um buraco <empty item>, ou seja sem alterar os índices
delete nomes[2];

// Slice com valor negativo começa a remover elementos a partir do final
// nomes.slice(0, -2)
// ["Eduardo", "Maria", "Joana"]
// ["Eduardo"]