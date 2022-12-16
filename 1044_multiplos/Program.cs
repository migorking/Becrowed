using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace multiplos_1043 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n1, n2;
            string[] entradas = Console.ReadLine().Split(' ');

            n1 = Convert.ToInt32(entradas[0]);
            n2 = Convert.ToInt32(entradas[1]);

            if (n1 % n2 == 0 || n2 % n1 == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }

            Console.ReadKey();
        }
    }
}

