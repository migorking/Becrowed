using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace grenais_1131 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] entradas;
            int golInter, golGremio;
            int contador;
            int vitoriaGremio = 0, vitoriaInter = 0, empate = 0, grenais = 0;

            entradas = Console.ReadLine().Split(' ');
            golInter = Convert.ToInt32(entradas[0]);
            golGremio = Convert.ToInt32(entradas[1]);
            grenais++;

            if (golInter > golGremio)
            {
                vitoriaInter++;
            }
            else if (golInter < golGremio)
            {
                vitoriaGremio++;
            }
            else
            {
                empate++;
            }

            Console.WriteLine("Novo grenal (1-sim 2-nao)");
            contador = int.Parse(Console.ReadLine());

            while (contador == 1)
            {
                entradas = Console.ReadLine().Split(' ');
                golInter = Convert.ToInt32(entradas[0]);
                golGremio = Convert.ToInt32(entradas[1]);
                grenais++;

                if (golInter > golGremio)
                {
                    vitoriaInter++;
                }
                else if (golInter < golGremio)
                {
                    vitoriaGremio++;
                }
                else
                {
                    empate++;
                }
                
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                contador = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(grenais + " grenais");
            Console.WriteLine("Inter:" + vitoriaInter);
            Console.WriteLine("Gremio:" + vitoriaGremio);
            Console.WriteLine("Empates:" + empate);
            
            if (vitoriaInter > vitoriaGremio && vitoriaInter > empate)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else if (vitoriaGremio > vitoriaInter && vitoriaGremio > empate)
            {
                Console.WriteLine("Gremio venceu mais");
            }
            else 
            {
                Console.WriteLine("Nao houve vencedor");

            }
        }
    }
}
