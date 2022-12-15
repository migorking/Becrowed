using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Lanches_1038 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int quantidade, cod;
            double CachorroQuente, xSalada, xBacon, TorradaSimples, Refri, total;


            string[] entradas = Console.ReadLine().Split(' ');

            cod = int.Parse(entradas[0]);
            quantidade= int.Parse(entradas[1]);

            CachorroQuente = 4.00;
            xSalada = 4.50;
            xBacon = 5.00;
            TorradaSimples = 2.00;
            Refri = 1.50;


            if (cod == 1)
            {
                total = quantidade * CachorroQuente;
                Console.WriteLine($"Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (cod == 2)
            {
                total = quantidade * xSalada;
                Console.WriteLine($"Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (cod == 3)
            {
                total = quantidade * xBacon;
                Console.WriteLine($"Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (cod == 4)
            {
                total = quantidade * TorradaSimples;
                Console.WriteLine($"Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                total = quantidade * Refri;
                Console.WriteLine($"Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }

            
            Console.ReadKey();
        }
    }
}

