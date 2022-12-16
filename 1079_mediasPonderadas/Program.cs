using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.ComponentModel;

namespace areaCirculo_1002 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int entradaN = int.Parse(Console.ReadLine());
            
            double nota1, nota2, nota3;

            for (int i = 0; i < entradaN; i++)
            {
                string[] notas = (Console.ReadLine().Split(' '));

                nota1 = double.Parse(notas[0], CultureInfo.InvariantCulture);
                nota2 = double.Parse(notas[1], CultureInfo.InvariantCulture);
                nota3 = double.Parse(notas[2], CultureInfo.InvariantCulture);

                double m1 = (nota1 * 2) / 10;
                double m2 = (nota2 * 3) / 10;
                double m3 = (nota3 * 5) / 10;

                double mediaPonderada = m1 + m2 + m3;
                Console.WriteLine(mediaPonderada.ToString("f1", CultureInfo.InvariantCulture));
            }

           



            Console.ReadKey();
        }
    }
}

