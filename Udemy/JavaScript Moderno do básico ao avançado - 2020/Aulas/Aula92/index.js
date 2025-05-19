// Métodos úteis para objetos

// Copiar objeto
const produto = { nome: 'Caneca', preco: 1.8 };
// 1
const outroProduto = {...produto, material: 'Porcelana'};

// 2
const caneca = Object.assign({}, produto);

// 3
const caneca2 = {nome: produto.nome};

// Recuperar as propriedades (chaves) de um objeto
Object.keys(produto);

// Congelar um objeto para prevenir alterações no objeto em si e em suas propriedades
// Object.freeze(produto);

// getOwnPropertyDescriptor - retorna as definições da propriedade do objeto (writable, enumerable, configurable)
Object.getOwnPropertyDescriptor(produto, "nome");

// Object.Values
Object.values(produto);

// Object.entries: retorna as chaves e valores separados por array com par de chave/valor
Object.entries(produto);