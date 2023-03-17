var input = require('fs').readFileSync('stdin', 'utf8');
var lines = input.split(' ');

const a = parseFloat(lines.shift())
const b = parseFloat(lines.shift())
const c = parseFloat(lines.shift())

const delta = Math.sqrt((Math.pow(b,2)) - (4*a*c))

if (delta < 0.0 || delta === 0.0 || b === 0.0 || a === 0.0 || c === 0.0) {
    console.log("Impossivel calcular")
}
else {
    const x1 = ((-b) + delta) / (2*a)
    const x2 = ((-b) - delta) / (2*a)
    console.log('R1 =', x1.toFixed(5))
    console.log('R2 =', x2.toFixed(5))
}