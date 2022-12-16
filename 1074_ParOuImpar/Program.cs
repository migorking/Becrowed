using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace parOuImpar_1074 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int entradaN = int.Parse(Console.ReadLine());
            int entrada1;
            for (int i = 0; i < entradaN; i++)
            {
                entrada1 = int.Parse(Console.ReadLine());
                if (entrada1 == 0)
                {
                    Console.WriteLine("NULL");
                }
                else if (entrada1 % 2 == 0 && entrada1 > 0)
                {
                    Console.WriteLine("EVEN POSITIVE");
                }
                else if (entrada1 % 2 == 0 && entrada1 < 0)
                {
                    Console.WriteLine("EVEN NEGATIVE");
                }
                else if (entrada1 % 2 != 0 && entrada1 > 0)
                {
                    Console.WriteLine("ODD POSITIVE");
                }
                else if (entrada1 % 2 != 0 && entrada1 < 0)
                {
                    Console.WriteLine("ODD NEGATIVE");
                }
            }




            Console.ReadKey();
        }
    }
}

