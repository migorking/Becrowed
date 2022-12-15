using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DistanciaEntreDoisPontos_1015 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {

            string[] entrada1 = Console.ReadLine().Split(' ');

            double x1 = Convert.ToDouble(entrada1[0], CultureInfo.InvariantCulture);
            double y1 = Convert.ToDouble(entrada1[1], CultureInfo.InvariantCulture);

            string[] entrada2 = Console.ReadLine().Split(' ');

            double x2 = double.Parse(entrada2[0], CultureInfo.InvariantCulture);
            double y2 = double.Parse(entrada2[1], CultureInfo.InvariantCulture);

            double r1 = Math.Pow((x2 - x1), 2);
            double r2 = Math.Pow((y2 - y1), 2);

            double DistDoisPontos = Math.Sqrt((r1 + r2));

            Console.WriteLine(DistDoisPontos.ToString("f4"), CultureInfo.InvariantCulture);


            Console.ReadKey();
        }
    }
}

