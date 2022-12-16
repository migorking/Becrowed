using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace tempoDoJogo_1046 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int horaInicial, horaFinal, totalHrsJogadas;

            string[] entrada = Console.ReadLine().Split(' ');

            horaInicial = Convert.ToInt32(entrada[0]);
            horaFinal = Convert.ToInt32(entrada[1]);

            if (horaInicial == horaFinal)
            {
                Console.WriteLine("O JOGO DUROU 24 HORA(S)");
            }
            else
            {
                if (horaInicial > horaFinal)
                {
                    totalHrsJogadas = (horaFinal + 24) - horaInicial;
                    Console.WriteLine($"O JOGO DUROU {totalHrsJogadas} HORA(S)");
                }
                else if (horaInicial < horaFinal)
                {
                    totalHrsJogadas = horaFinal - horaInicial;
                    Console.WriteLine($"O JOGO DUROU {totalHrsJogadas} HORA(S)");
                }
            }
            Console.ReadKey();
        }
    }
}

