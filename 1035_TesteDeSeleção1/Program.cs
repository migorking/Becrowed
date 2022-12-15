using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace testeDeSelecao1_1035 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int a, b, c, d;
            string[] entrada = Console.ReadLine().Split(' ');

            a = Convert.ToInt32(entrada[0]);
            b = Convert.ToInt32(entrada[1]);
            c = Convert.ToInt32(entrada[2]);
            d = Convert.ToInt32(entrada[3]);

            if (b > c && d > a && (c+d) > (a + b) && c > 0 && d > 0 && a % 2 == 0 )
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }


            Console.ReadKey();
        }
    }
}

