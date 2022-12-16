using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace quadradoDosPares_1073 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int entradaN = int.Parse(Console.ReadLine());

            for (int i = 1; i <= entradaN; i++)
            {
                if (i % 2 == 0)
                {
                    int potencializacao = i * i;
                    Console.WriteLine(i + "^2 = " + potencializacao);
                }
            }

            Console.ReadKey();
        }
    }
}

