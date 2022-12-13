using System;
using System.Globalization;

namespace media1_1005 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double A, B, MEDIA, peso1, peso2;
          
            peso1 = 3.5;
            peso2 = 7.5;

           //Console.Write("Digite a primeira nota: ");
            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Digite a segunda nota: ");
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            MEDIA = (A * peso1 + B * peso2) / (peso1 + peso2);

            Console.WriteLine($"MEDIA = {MEDIA.ToString("f5", CultureInfo.InvariantCulture)}");

            Console.ReadKey();
        }
    }
}

