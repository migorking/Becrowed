using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Tabuada_1078 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int entradaN = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++) 
            {
                int multiplicador = entradaN * i;
                Console.WriteLine($"{i} x {entradaN} = {multiplicador}");

            }

            Console.ReadKey();
        }
    }
}

