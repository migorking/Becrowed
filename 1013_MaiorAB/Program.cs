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
            int n1, n2, n3, maiorab;

            string[] entradas = Console.ReadLine().Split(' ');

            n1 = int.Parse(entradas[0]);
            n2 = int.Parse(entradas[1]);
            n3 = int.Parse(entradas[2]);

            maiorab = ((n1 + n2) + Math.Abs(n1 - n2)) / 2;
            int maiorabc = ((maiorab + n3) + Math.Abs(maiorab - n3)) / 2;

            Console.WriteLine(maiorabc + " eh o maior");
            Console.ReadKey();
        }
    }
}

