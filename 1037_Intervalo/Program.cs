using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Intervalo_1037 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {

            double entrada = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (entrada >= 0 && (entrada <= 25))
            {
                Console.WriteLine("Intervalo [0,25]");

            }
            else if (entrada > 25 && (entrada <= 50))
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (entrada > 50 && (entrada <= 75))
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if (entrada > 75 && (entrada <= 100))
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else 
            {
                Console.WriteLine("Fora de intervalo");
            }

            Console.ReadKey();
        }
    }
}

