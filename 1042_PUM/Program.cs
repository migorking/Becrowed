using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace areaCirculo_1002 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int entradaN = int.Parse(Console.ReadLine());
            int cont = 0;
            int linhas = entradaN * 4;

            for (int i = 1; i <= linhas; i++)
            {
                cont++;
                if (cont % 4 != 0)
                {
                    Console.Write(cont + " ");
                }
                else
                {
                    Console.WriteLine("PUM");
                }
            }
        }
    }
}