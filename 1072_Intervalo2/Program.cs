using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace intervalo2_1072 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int entradaN = int.Parse(Console.ReadLine());
            int valores, numerosIn, numerosOut;

            numerosIn = 0;
            numerosOut = 0;

            for (int i = 0; i < entradaN; i++)
            {
                valores= int.Parse(Console.ReadLine());

                if (valores >= 10 && valores <=20)
                {
                    numerosIn++;
                }
                else
                {
                    numerosOut++;
                }

            }
            Console.WriteLine(numerosIn + " in");
            Console.WriteLine(numerosOut + " out");



            Console.ReadKey();
        }
    }
}

