using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace areaCirculo_1002 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int entradaX, entradaY, min, max;
            int soma = 0;

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

            for(int i = min; i <= max; i++) 
            { 
            
                if (i % 13 != 0)
                {
                    soma += i;
                }

            }
            Console.WriteLine(soma);

            Console.ReadKey();
        }
    }
}

