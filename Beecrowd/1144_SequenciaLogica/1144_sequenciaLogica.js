var input = require("fs").readFileSync("stdin", "utf8");
var lines = input.split("\n");

let entrada = parseInt(lines.shift());

for (let i = 1; i <= entrada; i++) {
  console.log(`${i} ${i ** 2} ${i ** 3}`);
  console.log(`${i} ${i ** 2 + 1} ${i ** 3 + 1}`);
}
