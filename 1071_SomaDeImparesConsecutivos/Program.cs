using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SomaDeImparesConsecutivos_1071 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int entrada1 = int.Parse(Console.ReadLine());
            int entrada2 = int.Parse(Console.ReadLine());
            int maior, menor, resultado;


            resultado = 0;

            if (entrada1 < entrada2)
            {
                menor = entrada1;
                maior = entrada2;
            }
            else
            {
                menor = entrada2;
                maior = entrada1;
            }

            
            for (int i = (menor + 1); i < maior; i++)
            {
                if (i % 2 != 0)
                {
                    resultado = resultado + i;

                }
                
            }
            Console.WriteLine(resultado);

            Console.ReadKey();
        }
    }
}

