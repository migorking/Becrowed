using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CrescenteDecrescente_1113 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] valores;
            int entradaX, entradaY;

            valores = Console.ReadLine().Split(' ');
            entradaX = int.Parse(valores[0]);
            entradaY = int.Parse(valores[1]);

            while (entradaX != entradaY)
            {

                if (entradaX > entradaY)
                {
                    Console.WriteLine("Decrescente");
                }
                else
                {
                    Console.WriteLine("Crescente");
                }

                valores = Console.ReadLine().Split(' ');
                entradaX = int.Parse(valores[0]);
                entradaY = int.Parse(valores[1]);

            }

        }
    }
}

