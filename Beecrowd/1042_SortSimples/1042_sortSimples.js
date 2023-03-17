var input = require('fs').readFileSync('stdin', 'utf8');
var lines = input.split('\n');

const inicial = (a, b) => a - b;

let entradas = lines.shift().trim().split(' ').map((x) => parseInt(x));
let entradasCopy = [...entradas];

entradasCopy.sort(inicial);

for(let i = 0; i < 3; ++i){
    console.log(entradasCopy[i]);
}
console.log();
for(let i = 0; i < 3; ++i){
    console.log(entradas[i]);
}