console.log('João Pedro' && 0 && 'Maria'); // -> retorna 0 porque o valor avaliado em FALSE é 0
console.log('João Pedro' && true && 'Maria'); // -> retorna 'Maria' porque é a última expressão verdadeira encontrada

/**
 * FALSE -> valor literal false
 * FALSY -> retornam valor avaliado em false (0, '', "", ``, null, undefined, NaN) se avaliados em expressões lógicas
 * Qualquer coisa diferente das de cima é avaliado em 'true' pelo Javascript
 */

 //Avaliação de curto circuito
 function falaOi(){
     return 'Oi';
 }

 const vaiExecutar = false;
 console.log(vaiExecutar && falaOi());
 // Como 'vaiExecutar' retorna false, nem vai executar a função 'falaOi'.
 // Alterando o valor para true, a função será executada.

 console.log(0 || false || null || 'João Pedro' || true); // expressões com OR só necessita de um valor verdadeiro
 // como a string 'João Pedro' não é vazia, nem nula, ou undefined, é retornada como o primeiro valor verdadeiro

 const a = 0;
 const b = null;
 const c = 'false';// -> Esse será o valor exibido como verdadeiro.
 const d = false;
 const e = NaN;

 console.log(a || b || c || d || e);