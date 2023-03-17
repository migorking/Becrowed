var input = require("fs").readFileSync("stdin", "utf8");
var lines = input.split("\n");

let a = parseInt(lines.shift());
let b = parseInt(lines.shift());
let aux;

if (a > b) {
  aux = a;
  a = b;
  b = aux;
}

let soma = 0;
for (let i = a; i <= b; i++) {
  if (i % 13 !== 0) {
  soma = i + soma;
}
}
console.log(soma)