using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace QuadradoEAoCubo_1143 //aqui nome do projeto sempre
{
    public class Program
    {

        public static void Main(string[] args)
        {
            int entradaN;
            int elevarAoQuadrado = 0;
            int elevarAoCubo = 0;


            entradaN = int.Parse(Console.ReadLine());



            for (int i = 1; i <= entradaN; i++)
            {

                elevarAoQuadrado = i * i;
                elevarAoCubo = elevarAoQuadrado * i;
                Console.Write(i + " ");
                Console.Write(elevarAoQuadrado + " ");
                Console.WriteLine(elevarAoCubo);

            }








            Console.ReadKey();
        }
    }
}


