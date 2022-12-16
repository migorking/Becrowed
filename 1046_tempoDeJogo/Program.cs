using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace areaCirculo_1002 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int horaInicial, horaFinal;
            string[] entrada = Console.ReadLine().Split(' ');

            horaInicial = Convert.ToInt32(entrada[0]);
            horaFinal = Convert.ToInt32(entrada[1]);

            if (horaInicial == horaFinal)
            {
                Console.WriteLine("O JOGO DUROU 24 HORA(S)");
            }
            


            Console.ReadKey();
        }
    }
}

