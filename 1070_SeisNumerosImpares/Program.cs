using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace SeisNumerosImpares_1070 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int impares = 0;
            int entrada = int.Parse(Console.ReadLine());
            
            while (impares < 6)
            {
                if (entrada % 2 !=0)
                {
                    Console.WriteLine(entrada);
                    impares++;
                    entrada++;
                }
                else
                {
                    entrada++;
                }
            }



            Console.ReadKey();
        }
    }
}

