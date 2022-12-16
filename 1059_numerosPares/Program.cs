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
            for (int count = 1; count <= 100; count++)
            {
                if ( count % 2 == 0 )
                {
                    Console.WriteLine(count);
                }
            }

            Console.ReadKey();
        }
    }
}

