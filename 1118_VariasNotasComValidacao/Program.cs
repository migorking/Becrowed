using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace NotasComValidacao_1118 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double notas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double nota1 = 0.0, nota2 = 0.0;
            double media = 0.0;
            int contador = 1;


            while ( contador == 1)
            {
                while (notas < 0.0 || notas > 10.0 )
                {
                    Console.WriteLine("nota invalida");
                    notas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
                nota1 = notas;

                notas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while (notas < 0.0 || notas > 10.0)
                {
                    Console.WriteLine("nota invalida");
                    notas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
                nota2 = notas;

                media = (nota1 + nota2) / 2.0;
                Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));

                Console.WriteLine("novo calculo (1-sim 2-nao)");
                contador = int.Parse(Console.ReadLine());

                while (contador < 1 || contador > 2) {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    contador = int.Parse(Console.ReadLine());

                }

            if (contador == 1)
            {
                notas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            }
        }
    }
}

