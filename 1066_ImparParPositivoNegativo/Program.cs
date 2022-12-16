using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ImparParPositivoNegativo_1066 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int positivo, negativo, par, impar, contador;
            positivo = 0;
            negativo = 0;
            par = 0;
            impar = 0;
            contador = 0;


            for (int i = 0; i < 5; i++)
            {
                int entrada = int.Parse(Console.ReadLine());
                if ((entrada % 2) == 0)
                {
                    par++;
                }
                else
                {
                    impar++;
                }

                if (entrada > 0)
                {
                    positivo++;
                }
                else if (entrada < 0)
                {
                    negativo++;
                }

            }

            Console.WriteLine(par + " valor(es) par(es)");
            Console.WriteLine(impar + " valor(es) impar(es)");
            Console.WriteLine(positivo + " valor(es) positivo(s)");
            Console.WriteLine(negativo + " valor(es) negativo(s)");


            Console.ReadKey();
        }
    }
}

