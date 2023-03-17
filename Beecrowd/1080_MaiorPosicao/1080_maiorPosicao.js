var input = require("fs").readFileSync("stdin", "utf8");
var lines = input.split("\n");

let maior = 0;
let posicao = 0;
let x;

for (let i = 1; i <= 100; i++) {
    x = parseInt(lines.shift())
    if(x > maior) {
        maior = x
        posicao = i
    }
}

console.log(maior)
console.log(posicao)