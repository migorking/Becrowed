using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Baskhara_1036 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {

            double A, B, C, R1, R2, delta, divisor;

            string[] entradas = Console.ReadLine().Split(' ');

            A = Convert.ToDouble(entradas[0], CultureInfo.InvariantCulture);
            B = Convert.ToDouble(entradas[1], CultureInfo.InvariantCulture);
            C = Convert.ToDouble(entradas[2], CultureInfo.InvariantCulture);

            delta = Math.Sqrt((Math.Pow(B, 2)) - (4 * A * C));
            
            divisor = (2 * A);


            if (delta > 0 && divisor != 0)
            {
                R1 = (-B + delta) / divisor;
                R2 = (-B - delta) / divisor;
                Console.WriteLine($"R1 = " + R1.ToString("f5", CultureInfo.InvariantCulture));
                Console.WriteLine($"R2 = " + R2.ToString("f5", CultureInfo.InvariantCulture));
            }

            else
            {

                Console.WriteLine("Impossivel calcular");

            }

            Console.ReadKey();
        }
    }
}

