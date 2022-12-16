using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace NotasValidas_1117 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double notas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double nota1 = 0.0, nota2 = 0.0;
            double media = 0.0;
            int contador = 0;


            while (contador < 2)
            {
                if (notas >= 0.0 && notas <= 10.0)
                {
                    if (contador == 0)
                    {
                        nota1 = notas;
                        notas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    }else
                    {
                        nota2 = notas;
                    }
                    contador++;
                }
                else
                {
                    Console.WriteLine("nota invalida");
                    notas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                }

            }
            media = (nota1 + nota2) / 2;

            Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}

