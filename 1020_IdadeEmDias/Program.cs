using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Idade_1020 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int N, anos, meses, dias, resto;

            N = Convert.ToInt32(Console.ReadLine());

            anos = N / 365;
            resto = N % 365;

            meses = resto / 30;
            resto = resto % 30;

            dias = resto;


            Console.WriteLine($"{anos} ano(s)");
            Console.WriteLine($"{meses} mes(es)");
            Console.WriteLine($"{dias} dia(s)");


            Console.ReadKey();
        }
    }
}

