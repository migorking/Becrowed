var input = require('fs').readFileSync('stdin', 'utf8');
var lines = input.split('\n');


let [a, b] = lines.shift().trim().split(" ").map((x) => parseFloat(x));


if(a < b) {
    aux = b
    b = a
    a = aux
}

if (a % b === 0) {
    console.log("Sao Multiplos")
}
else {
    console.log("Nao sao Multiplos")
}