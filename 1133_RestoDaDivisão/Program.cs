using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace RestoDaDivisão_1133 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int entradaX, entradaY, min, max;


            entradaX = Convert.ToInt32(Console.ReadLine());
            entradaY = Convert.ToInt32(Console.ReadLine());

            if (entradaX > entradaY)
            {
                min = entradaY;
                max = entradaX;
            }
            else
            {
                min = entradaX;
                max = entradaY;
            }

            int interacao = max - min-1; //pq senão o 18 vai sair no cw

            for (int i = 0; i < interacao; i++)
            {
                min++;

                if (min % 5 == 2 || min % 5 == 3)
                {
                    Console.WriteLine(min);
                }
            }


            Console.ReadKey();
        }
    }
}

