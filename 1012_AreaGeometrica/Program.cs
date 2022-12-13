using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace areaGeometrica_1012 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] entrada = Console.ReadLine().Split(' ');

            double A = Double.Parse(entrada[0], CultureInfo.InvariantCulture);
            double B = Double.Parse(entrada[1], CultureInfo.InvariantCulture);
            double C = Double.Parse(entrada[2], CultureInfo.InvariantCulture);

            double Triangulo = (A * C)/2;
            double Circulo = 3.14159 * Math.Pow(C, 2);
            double Trapezio = (A + B) * C / 2;
            double Quadrado = Math.Pow(B, 2);
            double Retangulo = A * B;

            Console.WriteLine($"TRIANGULO: {Triangulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"CIRCULO: {Circulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"TRAPEZIO: {Trapezio.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"QUADRADO: {Quadrado.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"RETANGULO: {Retangulo.ToString("F3", CultureInfo.InvariantCulture)}");



            Console.ReadKey();

        }
    }
}

