using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Quadrante_1115 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] entrada;
            int entradaX, entradaY;

            entrada = Console.ReadLine().Split(' ');

            entradaX = int.Parse(entrada[0]);
            entradaY = int.Parse(entrada[1]);

            while(entradaX != 0 || entradaY != 0)
            {
                if (entradaX == 0 || entradaY == 0)
                {
                    Console.WriteLine();
                }
                else
                {
                if (entradaX > 0 && entradaY > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (entradaX < 0 && entradaY > 0)
                {
                    Console.WriteLine("segundo");
                }
                else if(entradaX < 0 && entradaY < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else
                {
                    Console.WriteLine("quarto");
                }
                }
                entrada = Console.ReadLine().Split(' ');

                entradaX = int.Parse(entrada[0]);
                entradaY = int.Parse(entrada[1]);
            }

            Console.ReadKey();
        }
    }
}

