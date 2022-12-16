using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace sortSimples_1042 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n1, n2 , n3;
            string[] entrada = Console.ReadLine().Split(' ');

            n1 = int.Parse(entrada[0]);
            n2= int.Parse(entrada[1]);
            n3= int.Parse(entrada[2]);

            if (n1 > n2 && n1 > n3 && n2 > n3)
            {
                Console.WriteLine(n3);
                Console.WriteLine(n2);
                Console.WriteLine($"{n1}\n");
            }
            else if (n1 > n2 && n1 > n3 && n2 < n3)
            {
                Console.WriteLine(n2);
                Console.WriteLine(n3);
                Console.WriteLine($"{n1}\n");
            }
            else if (n2 > n1 && n2 > n3 && n1 > n3)
            {
                Console.WriteLine(n3);
                Console.WriteLine(n1);
                Console.WriteLine($"{n2}\n");
            }
            else if (n2 > n1 && n2 > n3 && n1 < n3)
            {
                Console.WriteLine(n1);
                Console.WriteLine(n3);
                Console.WriteLine($"{n2}\n");
            }
            else if (n3 > n1 && n3 > n2 && n1 > n2)
            {
                Console.WriteLine(n2);
                Console.WriteLine(n1);
                Console.WriteLine($"{n3}\n");
            }
            else if (n3 > n1 && n3 > n2 && n1 < n2)
            {
                Console.WriteLine(n1);
                Console.WriteLine(n2);
                Console.WriteLine($"{n3}\n");
            }


            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);

            Console.ReadKey();
        }
    }
}

