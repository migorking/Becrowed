using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Runtime.Serialization;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace SequenciaDosNumeroseSoma_1101 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int entradaM, entradaN, min, max;
            string[] valores;


            valores = (Console.ReadLine().Split(' '));
            entradaM = Convert.ToInt32(valores[0]);
            entradaN = Convert.ToInt32(valores[1]);

            while (entradaM > 0 && entradaN > 0)
            {
                min = 0;
                max = 0;
                int soma = 0;

                if (entradaM >= entradaN)
                {
                    min = entradaN;
                    max = entradaM;

                }
                else
                {
                    min = entradaM;
                    max = entradaN;
                }

                for (int i = min; i <= max; i++)
                {
                    Console.Write(i + " ");
                    soma += i;

                }
                Console.WriteLine("Sum=" + soma);

                valores = Console.ReadLine().Split(' ');

                entradaM = Convert.ToInt32(valores[0]);
                entradaN = Convert.ToInt32(valores[1]);

            }

         
        }
    }
}