using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CombustivelGasto_1014 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int Km = int.Parse(Console.ReadLine());
            double gasGasto = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            double KmPorLitro = Km/gasGasto;

            Console.WriteLine(KmPorLitro.ToString("f3", CultureInfo.InvariantCulture) + " km/l");


            Console.ReadKey();
        }
    }
}

