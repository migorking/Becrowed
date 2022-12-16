using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace NumeroImpares_1067 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {
           
            int entrada = int.Parse(Console.ReadLine());
            int x = 1;

            while (entrada >= x)
            {
                if (x % 2 != 0)
                {
                    Console.WriteLine(x);
                    x++;
                }
                else
                {
                    x++;
                }

            }
            
           

            Console.ReadKey();
        }
    }
}

