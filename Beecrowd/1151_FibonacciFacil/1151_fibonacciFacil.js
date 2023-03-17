var input = require('fs').readFileSync('stdin', 'utf8');
var lines = input.split('\n');


let entrada = parseInt(lines.shift());

let primeiroNumero = 0;
let segundoNumero = 1;
let sequencia = '';

for (let i = 0; i < entrada; i++) {
    sequencia += primeiroNumero + ' ';
    let proximoNumero = primeiroNumero + segundoNumero;
    primeiroNumero = segundoNumero;
    segundoNumero = proximoNumero;
}


console.log(sequencia.trim());