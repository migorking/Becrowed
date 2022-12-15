using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Cedulas_Moedas1021 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {

            double N, n100, n50, n20, n10, n5, n2, m1, m50, m25, m10, m5, m1c, divisor;

            N = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            n100 = N / 100;
            divisor = N % 100;
            

            n50 = divisor / 50;
            divisor = divisor % 50;
            

            n20 = divisor / 20;
            divisor = divisor % 20;
            

            n10 = divisor / 10;
            divisor = divisor % 10;
            

            n5 = divisor / 5;
            divisor = divisor % 5;
            

            n2 = divisor / 2;
            divisor = divisor % 2;
            
            m1 = divisor / 1;
            divisor = divisor % 1;

            divisor = divisor * 100;
            
            m50 = divisor / 50;
            divisor = divisor % 50;
            

            m25 = divisor / 25;
            divisor = divisor % 25;
            

            m10 = divisor / 10;
            divisor = divisor % 10;
            

            m5 = divisor / 5;
            divisor = divisor % 5;
            
            m1c = divisor / 1;
            divisor = divisor % 1;
            
            Console.WriteLine("NOTAS:");
            Console.WriteLine((int)n100 + " nota(s) de R$ 100.00");
            Console.WriteLine((int)n50 + " nota(s) de R$ 50.00");
            Console.WriteLine((int)n20 + " nota(s) de R$ 20.00");
            Console.WriteLine((int)n10 + " nota(s) de R$ 10.00");
            Console.WriteLine((int)n5 + " nota(s) de R$ 5.00");
            Console.WriteLine((int)n2 + " nota(s) de R$ 2.00");
            Console.WriteLine("MOEDAS:");
            Console.WriteLine((int)m1 + " moeda(s) de R$ 1.00");
            Console.WriteLine((int)m50 + " moeda(s) de R$ 0.50");
            Console.WriteLine((int)m25 + " moeda(s) de R$ 0.25");
            Console.WriteLine((int)m10 + " moeda(s) de R$ 0.10");
            Console.WriteLine((int)m5 + " moeda(s) de R$ 0.05");
            Console.WriteLine((int)m1c + " moeda(s) de R$ 0.01");

            Console.ReadKey();
        }
    }
}