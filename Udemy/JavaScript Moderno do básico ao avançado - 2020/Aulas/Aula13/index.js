// Indexadas     0123456789...
let texto = "Um \"texto\"";// \ para escapar caracteres.
let umaString = "O rato roeu a roupa do rei de roma";

console.log(umaString[0]);
console.log(umaString.charAt(0));
console.log(umaString.charCodeAt(0));

console.log(umaString.concat(' ',"em",' ',"um"," ","lindo"," ","dia."));
console.log(umaString + " em um lindo dia.");
console.log(`${umaString} em um lindo dia.`);

console.log(umaString.indexOf('texto'));
console.log(umaString.indexOf('texto', 3));
console.log(umaString.lastIndexOf('texto'));
console.log(umaString.lastIndexOf('texto', 3));

console.log(umaString.match(/[a-z]/));
console.log(umaString.match(/[a-z]/g));

console.log(umaString.search(/[a-z]/g));

console.log(umaString.replace('Um', 'Uma'));
console.log(umaString.replace(/Um/, 'Uma'));
console.log(umaString.replace(/r/, '#'));

console.log(umaString.length);

console.log(umaString.slice(2, 6));
console.log(umaString.slice(-5)); // umaString.length - 5
console.log(umaString.slice(-5, -1));

console.log(umaString.substring(umaString.length - 5));
console.log(umaString.substring(umaString.length - 5, umaString.length - 1));

console.log(umaString.split(' '));
console.log(umaString.split(' ', 3));

console.log(umaString.toUpperCase());
console.log(umaString.toLowerCase());