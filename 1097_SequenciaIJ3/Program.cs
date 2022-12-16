using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace sequenciaIJ3_1097 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int entradaI, entradaJ;

            entradaI = 1;
            entradaJ = 7;

            while (entradaI <= 9)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine($"I={entradaI} J={entradaJ}");
                    entradaJ--;

                }
                entradaJ += 5;
                entradaI += 2;
                
            }

            Console.ReadKey();
        }
    }
}

