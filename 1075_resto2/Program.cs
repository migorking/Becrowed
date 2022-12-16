using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace resto2_1075 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int entradaN = int.Parse(Console.ReadLine());

            for (int i = 1; i < 10000;i++)
            {
                if (i % entradaN == 2)
                {
                    Console.WriteLine(i);
                }


            }

            Console.ReadKey();
        }
    }
}

