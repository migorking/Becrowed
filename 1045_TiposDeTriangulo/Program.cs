using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace tiposDeTriangulo_1045 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //se A ≥ B+C, apresente a mensagem: NAO FORMA TRIANGULO
            // se A2 = B2 + C2, apresente a mensagem: TRIANGULO RETANGULO
            // se A2 > B2 + C2, apresente a mensagem: TRIANGULO OBTUSANGULO
            //se A2<B2 +C2, apresente a mensagem: TRIANGULO ACUTANGULO
            //se os três lados forem iguais, apresente a mensagem: TRIANGULO EQUILATERO
            //se apenas dois dos lados forem iguais, apresente a mensagem: TRIANGULO ISOSCELES


            double p1, p2, p3, x;



            string[] entradas = Console.ReadLine().Split(' ');

            p1 = Convert.ToDouble(entradas[0], CultureInfo.InvariantCulture);
            p2 = Convert.ToDouble(entradas[1], CultureInfo.InvariantCulture);
            p3 = Convert.ToDouble(entradas[2], CultureInfo.InvariantCulture);

            // estrutura de condição para colocar em ordem decrescente * (se inverter o < por > ai fica crescente)
            if (p1 < p2)
            {
                x = p1;
                p1 = p2;
                p2 = x;
            }
            if (p1 < p3)
            {
                x = p1;
                p1 = p3;
                p3 = x;
            }
            if (p2 < p3)
            {
                x = p2;
                p2 = p3;
                p3 = x;
            }

            if (p1 >= p2 + p3)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else
            {
                if ( (p1 * p1) == (p2*p2) + (p3*p3))
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                if ((p1 * p1) > (p2 * p2) + (p3 * p3))
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                if ((p1 * p1) < (p2 * p2) + (p3 * p3))
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }
                if (p1 == p2 && p1 == p3 && p2 == p3)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else
                {
                    if (p1 == p2 || p1 == p3 || p2 == p3) 
                    {
                        Console.WriteLine("TRIANGULO ISOSCELES");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}

