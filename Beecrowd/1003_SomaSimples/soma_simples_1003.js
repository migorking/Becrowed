var input = require('fs').readFileSync('stdin', 'utf8');
var lines = input.split('\n');

function soma (){
    let a = parseInt(lines.shift())
    let b = parseInt(lines.shift())

    return (a + b)
}

console.log(`SOMA = ${soma()}`)