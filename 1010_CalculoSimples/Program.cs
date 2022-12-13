using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CalculoSimples_1010 //aqui nome do projeto sempre
   {
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] compra = Console.ReadLine().Split(' ');
            int CodProd = Int32.Parse(compra[0]);
            int QuantidadeProd = Int32.Parse(compra[1]);
            double PrecoProd = Double.Parse(compra[2], CultureInfo.InvariantCulture);

            string[] compra2 = Console.ReadLine().Split(' ');
            int CodProd2 = Int32.Parse(compra2[0]);
            int QuantidadeProd2 = Int32.Parse(compra2[1]);
            double PrecoProd2 = Double.Parse(compra2[2], CultureInfo.InvariantCulture);

            double Total = (QuantidadeProd * PrecoProd) + (QuantidadeProd2 * PrecoProd2);

            Console.WriteLine($"VALOR A PAGAR: R$ {Total.ToString("f2", CultureInfo.InvariantCulture)}");

            Console.ReadKey();
        }
    }
}
