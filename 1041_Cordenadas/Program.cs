using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Cordenadas_1041 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double x, y;

            string[] entradas = Console.ReadLine().Split(' ');

            x = double.Parse(entradas[0], CultureInfo.InvariantCulture);
            y = double.Parse(entradas[1], CultureInfo.InvariantCulture);

            if (x == 0 && y == 0)
            {
                Console.WriteLine("Origem");              
            }
            else if (x == 0 && y != 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0 && x != 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            }
            Console.ReadKey();
        }
    }
}

