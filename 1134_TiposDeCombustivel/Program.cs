using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace TiposDeCombustivel_1134 //aqui nome do projeto sempre
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            int codigo;
            int etanol = 0, gasolina = 0, diesel = 0;

            codigo = int.Parse(Console.ReadLine());

            while (codigo != 4)
            {
                if (codigo == 1)
                {
                    etanol++;
                }
                else if ( codigo == 2)
                {
                    gasolina++;
                }
                else if (codigo == 3)
                {
                    diesel++;
                }

                codigo = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + etanol);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);



            Console.ReadKey();
        }
    }
}

