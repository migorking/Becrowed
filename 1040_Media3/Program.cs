using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace media3_1040 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {

            double n1, n2, n3, n4, exame, media, mediaFinal;

            string[] entrada = Console.ReadLine().Split(' ');

            n1 = Convert.ToDouble(entrada[0], CultureInfo.InvariantCulture);
            n2 = Convert.ToDouble(entrada[1], CultureInfo.InvariantCulture);
            n3 = Convert.ToDouble(entrada[2], CultureInfo.InvariantCulture);
            n4 = Convert.ToDouble(entrada[3], CultureInfo.InvariantCulture);

            int peso = (2+3+4+1);

            media = Math.Truncate(n1 * 2 + n2 * 3 + n3 * 4 + n4 * 1) / peso;
            
            if (media >= 7.0)
            {
                Console.WriteLine("Media: " + media.ToString("f1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media < 5.0)
            {
                Console.WriteLine("Media: " + media.ToString("f1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno reprovado.");
            }
            else
            {
                Console.WriteLine("Media: " + media.ToString("f1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno em exame.");

                exame = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                mediaFinal = (media + exame) / 2.0;
                Console.WriteLine("Nota do exame: " + exame.ToString("f1", CultureInfo.InvariantCulture));
                
                if (mediaFinal >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine("Media final: " + mediaFinal.ToString("f1", CultureInfo.InvariantCulture));
                }
                else 
                {
                    Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine("Media final: " + mediaFinal.ToString("f1", CultureInfo.InvariantCulture));
                }


            }

            Console.ReadKey();
        }
    }
}

