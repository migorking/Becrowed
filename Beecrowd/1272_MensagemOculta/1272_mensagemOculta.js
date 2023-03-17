var input = require("fs").readFileSync("stdin", "utf8");
var lines = input.split("\n");


const numCasosTeste = parseInt(lines.shift());


for (let i = 0; i < numCasosTeste; i++) {
  
  const texto = lines.shift();

  
  const palavras = texto.split('.');

  
  let mensagemOculta = '';

  
  for (let j = 0; j < palavras.length; j++) {
    
    mensagemOculta += palavras[j].charAt(0);
  }

  
  console.log(mensagemOculta);
}
