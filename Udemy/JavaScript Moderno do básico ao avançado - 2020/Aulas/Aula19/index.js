/*
 * Primitivos (imutáveis)- String, Number, Boolean, undefined, 
   null // bigint, symbol
   - Valores copiados

 * Referência (mutáveis) - Array, Object, Function 
   - Passados por referência
 */
 let a = [1,2,3];
 let b = {...a}; // Copiar o valor de 'a' para 'b', sem ser por referência
 let c = b;      // Aqui continua por referência.