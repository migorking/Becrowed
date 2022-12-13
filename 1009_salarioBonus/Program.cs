using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace salarioBonus_1009
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string nomeVendedor;
            double salarioFixo, comissao, total;

            nomeVendedor = Console.ReadLine();

            salarioFixo = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            comissao = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            total = (comissao * 0.15) + salarioFixo;

            Console.WriteLine($"TOTAL = R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.ReadKey();

        }
    }
}