using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SomaDosImpares2_1099 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int entradaN = Convert.ToInt32(Console.ReadLine());

            int min=0, max=0, entradaX, entradaY;
            


            for (int i = 0; i < entradaN; i++)
            {
                string[] entradas = Console.ReadLine().Split(' ');

                entradaX = Convert.ToInt32(entradas[0]);
                entradaY = Convert.ToInt32(entradas[1]);

                if (entradaX > entradaY)
                {
                    min = entradaY; max = entradaX;
                }
                else
                {
                    min = entradaX; max = entradaY;
                }

                int somaImpares = 0;
                min += 1;

                for (int e = min ; e < max; e++)
                {
                    if(e % 2 != 0)
                    {
                        somaImpares += e;
                      
                    }
                }
               
                Console.WriteLine(somaImpares);
            }
            



            Console.ReadKey();
        }
    }
}

