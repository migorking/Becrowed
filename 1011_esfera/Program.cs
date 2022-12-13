using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace esfera_1011 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double pi = 3.14159;
            double raio = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            double volume = (4.0 / 3) * pi * Math.Pow(raio, 3);

            Console.WriteLine("VOLUME = {0}", volume.ToString("F3", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}

