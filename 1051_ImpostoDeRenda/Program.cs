using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ImpostoDeRenda_1051 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double imposto, salario;

            salario = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario <= 2000.00)
            {
                Console.WriteLine("Isento");
            }
            else if (salario <= 3000)
            {
                imposto = (salario - 2000.00) * 0.08;
                Console.WriteLine("R$ " + imposto.ToString("f2", CultureInfo.InvariantCulture));
            }
            else if (salario <= 4500.00)
            {
                imposto = ((3000-2000.01) * 0.08) + ((salario - 3000.01) * 0.18);
                Console.WriteLine("R$ " + imposto.ToString("f2", CultureInfo.InvariantCulture));
            }
            else if (salario > 4500.00)
            {
                imposto = ((3000.00 - 2000.01) * 0.08) + ((4500.00 - 3000.01) * 0.18) + (salario - 4500.00) * 0.28;
                Console.WriteLine("R$ " + imposto.ToString("f2", CultureInfo.InvariantCulture));
            }
                
                
                               

            Console.ReadKey();
        }
    }
}

