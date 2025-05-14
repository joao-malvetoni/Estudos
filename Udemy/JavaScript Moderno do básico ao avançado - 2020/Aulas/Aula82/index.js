const nomes = ["Eduardo", "Maria", "Joana"];

// array.splice(indice inicial, 
//              quantos remover (length), 
//              ...elementos a serem inseridos no local das remoções ou novos a serem adicionados)
nomes.splice(4,1);
// Number.MAX_VALUE - vai até o final disponível (muito útil para arrays);