var input = require('fs').readFileSync('stdin', 'utf8');
var lines = input.split('\n');

let risada = lines.shift().trim();


let vogais = risada.match(/[aeiou]/g).join('');


if (vogais === vogais.split('').reverse().join('')) {
  console.log('S'); 
} else {
  console.log('N');
}