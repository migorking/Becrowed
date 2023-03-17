var input = require("fs").readFileSync("stdin", "utf8");
var lines = input.split("\n");

let entrada = parseInt(lines.shift());
let quadrado;

for (let i = 1; i <= entrada; i++) {
  if (i % 2 === 0) {
    quadrado = Math.pow(i,2);
    console.log(i + "^2" + " = " + quadrado);
  }
}
