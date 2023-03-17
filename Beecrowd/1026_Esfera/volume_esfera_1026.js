var input = require('fs').readFileSync('stdin', 'utf8');
var lines = input.split('\n');

const pi = 3.14159;

let r = parseFloat(lines.shift());

let volumeEsfera = (4.0/3*pi)*Math.pow(r,3);

console.log('VOLUME = ' + volumeEsfera.toFixed(3))