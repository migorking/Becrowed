using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DividindoXporY_1116 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] entrada;
            double entradaX, entradaY, interadorN, divisao;

            interadorN = int.Parse(Console.ReadLine());

            for (int i = 0; i < interadorN; i++)
            {
                entrada = Console.ReadLine().Split(' ');

                entradaX = double.Parse(entrada[0], CultureInfo.InvariantCulture);
                entradaY = double.Parse(entrada[1], CultureInfo.InvariantCulture);

                if (entradaY == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    if (entradaX == 0)
                    {
                        Console.WriteLine("0.0");
                    }
                    else
                    {
                        divisao = entradaX / entradaY;
                        Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                    }

                }

            }

            Console.ReadKey();
        }
    }
}

