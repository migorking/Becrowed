using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace cincoNumeros_1065 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int contador;
            contador = 0;

            for (int i = 0; i < 5; i++)
            {
                double entrada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (entrada % 2 == 0)
                {
                    contador++;
                }
            }

            Console.WriteLine(contador + " valores pares");


            Console.ReadKey();
        }
    }
}

