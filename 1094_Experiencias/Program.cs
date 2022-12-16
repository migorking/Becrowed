using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace experiencia_1094 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int entradaN, contRato, contCoelho, contSapo, total;
            

            entradaN= Convert.ToInt32(Console.ReadLine());

            contSapo = 0;
            contCoelho = 0;
            contRato = 0;
            total= 0;

            for (int i = 0; i < entradaN; i++)
            {
               string[] animais = (Console.ReadLine().Split(' '));

                int quantidade = Convert.ToInt32(animais[0]);
                char tipoAnimal = Convert.ToChar(animais[1]);

                total += quantidade;

                if (tipoAnimal == 'C')
                {
                    contCoelho += quantidade;
                }
                else if (tipoAnimal == 'R')
                {
                    contRato += quantidade;
                }
                else
                {
                    contSapo += quantidade;
                }
                
            }
            
            double porcCoelho = (contCoelho * 100.00) / total;
            double porcRato = (contRato * 100.00) / total;
            double porcSapo = (contSapo * 100.00) / total;


            Console.WriteLine($"Total: {total} cobaias");
            Console.WriteLine($"Total de coelhos: {contCoelho}");
            Console.WriteLine($"Total de ratos: {contRato}");
            Console.WriteLine($"Total de sapos: {contSapo}");
            Console.WriteLine($"Percentual de coelhos: {porcCoelho.ToString("F2", CultureInfo.InvariantCulture)} %");
            Console.WriteLine($"Percentual de ratos: {porcRato.ToString("F2", CultureInfo.InvariantCulture)} %");
            Console.WriteLine($"Percentual de sapos: {porcSapo.ToString("F2", CultureInfo.InvariantCulture)} %");
            
            




            Console.ReadKey();
        }
    }
}

