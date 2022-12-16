using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace TriangoAreaPerimetro_1043 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Só irá existir um triângulo se,
            //somente se, os seus lados obedeceram à seguinte regra: um de seus lados deve ser maior que o valor absoluto (módulo) da diferença dos outros dois lados e menor que a soma dos outros dois lados
            // 6 4 2 ( 6 > (4-2) = True 6 < (4+2) = false

            double lado1, lado2, lado3, perimetro, area;

            string[] entradas = Console.ReadLine().Split(' ');

            lado1 = Convert.ToDouble(entradas[0], CultureInfo.InvariantCulture);
            lado2 = Convert.ToDouble(entradas[1], CultureInfo.InvariantCulture);
            lado3 = Convert.ToDouble(entradas[2], CultureInfo.InvariantCulture);

            if (lado1 > Math.Abs(lado2 - lado3) && lado1 < (lado2 + lado3))
            {
                perimetro = lado1 + lado2 + lado3;
                Console.WriteLine("Perimetro = " + perimetro.ToString("f1"), CultureInfo.InvariantCulture);

            }
            else
            {
                area = ((lado1 + lado2) * lado3) / 2.0;
                Console.WriteLine("Area = " + area.ToString("f1"),CultureInfo.InvariantCulture);
            }
                

               

            Console.ReadKey();
        }
    }
}

