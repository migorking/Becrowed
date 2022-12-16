using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace areaCirculo_1002 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i, positivos;
            

            positivos = 0;

            for (i = 0; i < 6; i++)
            {
                double entrada = Convert.ToDouble(Console.ReadLine());
                if (entrada > 0)
                {
                    positivos++;
                }
            }
            Console.WriteLine($"{positivos} valores positivos");



            Console.ReadKey();
        }
    }
}

