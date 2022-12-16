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

            double salario, aumento, totalSalario;

            salario = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario <= 400.00)
            {
                aumento = salario * 0.15;
                totalSalario = salario + aumento;
                Console.WriteLine("Novo salario: " + totalSalario.ToString("f2"), CultureInfo.InvariantCulture);
                Console.WriteLine("Reajuste ganho: " + aumento.ToString("f2"), CultureInfo.InvariantCulture);
                Console.WriteLine("Em percentual: 15 %");
            }
            else if (salario <= 800)
            {
                aumento = salario * 0.12;
                totalSalario = salario + aumento;
                Console.WriteLine("Novo salario: " + totalSalario.ToString("f2"), CultureInfo.InvariantCulture);
                Console.WriteLine("Reajuste ganho: " + aumento.ToString("f2"), CultureInfo.InvariantCulture);
                Console.WriteLine("Em percentual: 12 %");
            }
            else if (salario <= 1200)
            {
                aumento = salario * 0.10;
                totalSalario = salario + aumento;
                Console.WriteLine("Novo salario: " + totalSalario.ToString("f2"), CultureInfo.InvariantCulture);
                Console.WriteLine("Reajuste ganho: " + aumento.ToString("f2"), CultureInfo.InvariantCulture);
                Console.WriteLine("Em percentual: 10 %");
            }
            else if (salario <= 2000)
            {
                aumento = salario * 0.07;
                totalSalario = salario + aumento;
                Console.WriteLine("Novo salario: " + totalSalario.ToString("f2"), CultureInfo.InvariantCulture);
                Console.WriteLine("Reajuste ganho: " + aumento.ToString("f2"), CultureInfo.InvariantCulture);
                Console.WriteLine("Em percentual: 7 %");
            }
            else
            {
                aumento = salario * 0.04;
                totalSalario = salario + aumento;
                Console.WriteLine("Novo salario: " + totalSalario.ToString("f2"), CultureInfo.InvariantCulture);
                Console.WriteLine("Reajuste ganho: " + aumento.ToString("f2"), CultureInfo.InvariantCulture);
                Console.WriteLine("Em percentual: 4 %");
            }

            Console.ReadKey();
        }
    }
}

