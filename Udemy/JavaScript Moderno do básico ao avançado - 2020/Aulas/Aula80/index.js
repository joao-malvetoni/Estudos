// funções geradoras, que a cada execução devolvem 1 valor diferente
function* geradora1(){
	yield 'valor 1';
	yield 'valor 2';
	yield 'valor 3';
}

const g1 = geradora1();
/*console.log(g1);
console.log(g1.next().value);
console.log(g1.next().value);
console.log(g1.next().value);
console.log(g1.next());*/

for (let valor of g1) {
	console.log(valor);
}

function* geradora2(){
	let i = 0;
	while(true){
		yield i;
		i++;
	}
}
const g2 = geradora2();
console.log(g2.next().value);
console.log(g2.next().value);
console.log(g2.next().value);
console.log(g2.next().value);
// ... quantos eu quiser, uma função geradora infinita

function* geradora3(){
	yield 0;
	yield 1;
	yield 2;
}

function* geradora4(){
	yield* geradora3();
	yield 3;
	yield 4;
	yield 5;
}

const g4 = geradora4();
for(let valor of g4) {
	console.log(valor);
}

function* geradora5(){
	yield function(){
		console.log('Fim do y1');
	};

	// Quando se tem o return, ele para a função geradora, independente do que vier depois
	// ou se tiver mais yields.
	return function(){
		console.log("Fim do return");
	}

	yield function(){
		console.log("Fim do y2");
	}
}

const g5 = geradora5();
const func1 = g5.next().value;
const func2 = g5.next().value;

func1();
func2();