var input = require("fs").readFileSync("stdin", "utf8");
var lines = input.split("\n");

let inicio = parseInt(lines.shift());

let dentro = 0;
let fora = 0;

for (let i = 0; i < inicio; i++) {
  let n1 = parseInt(lines.shift())
  
  if (n1 >= 10 && n1 <= 20) {
    dentro++;
  }
  else {
    fora++
  }
}
console.log(dentro + " in")
console.log(fora + " out")