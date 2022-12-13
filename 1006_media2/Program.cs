using System;
using System.Globalization;

namespace media2_1006 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double A, B, C, MEDIA;
            int peso1, peso2, peso3;


            peso1 = 2;
            peso2 = 3;
            peso3 = 5;


            //Console.WriteLine("Digite a primeira nota: ");
            A = Convert.ToDouble(Console.ReadLine(),CultureInfo.InvariantCulture);
            //Console.WriteLine("Digite a segunda nota: ");
            B = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
           // Console.WriteLine("Digite a terceira nota: ");
            C = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            MEDIA = (A * peso1 + B * peso2 + C * peso3) / (peso1 + peso2 + peso3);

            Console.WriteLine($"MEDIA = {MEDIA.ToString("F1", CultureInfo.InvariantCulture)}");

            Console.ReadKey();




        }
    }
}
