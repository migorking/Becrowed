using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConversaoTempo_1019 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int N = Convert.ToInt32(Console.ReadLine());

            int hora, min, segundo, restoHora;

            hora = N / 3600;
            restoHora = N % 3600;

            min = restoHora / 60;
            restoHora = restoHora % 60;

            segundo= restoHora;

            Console.WriteLine($"{hora}:{min}:{segundo}");







            Console.ReadKey();
        }
    }
}

