using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace positivosMedia_1064 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double somador, positivos, media;
            somador = 0.0;
            positivos = 0.0;
            media = 0.0;

            double[] conjunto = new double[6];

            for (int i = 0; i < 6; i++)
            {
                conjunto[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (conjunto[i] > 0)
                {
                    somador = somador + conjunto[i];
                    positivos++;
                    media = somador / positivos;
                }
            }

            Console.WriteLine(positivos + " valores positivos");
            Console.WriteLine(media.ToString("F1"), CultureInfo.InvariantCulture);



            Console.ReadKey();
        }
    }
}

