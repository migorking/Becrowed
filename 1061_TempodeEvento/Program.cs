using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Security.Cryptography;

namespace TempoDeEvento_1061 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int diaInicial, horaInicial, minInicial, segundoInicial, diaFinal, horaFinal, minFinal, segundoFinal;

            string[] dados1 = Console.ReadLine().Split(' ');
            string[] dados2 = Console.ReadLine().Split(':');

            diaInicial = Convert.ToInt32(dados1[1]);
            horaInicial = Convert.ToInt32(dados2[0]);
            minInicial = Convert.ToInt32(dados2[1]);
            segundoInicial = Convert.ToInt32(dados2[2]);

            string[] dados3 = Console.ReadLine().Split(' ');
            string[] dados4 = Console.ReadLine().Split(':');

            diaFinal = Convert.ToInt32(dados3[1]);
            horaFinal = Convert.ToInt32(dados4[0]);
            minFinal = Convert.ToInt32(dados4[1]);
            segundoFinal = Convert.ToInt32(dados4[2]);


            int tudoSegundosInicial = (diaInicial * 24*60*60) + (horaInicial * 60 * 60) + (minInicial * 60) + segundoInicial;
            int tudoSegundoFinal = (diaFinal * 24 * 60 * 60) + (horaFinal* 60*60) + (minFinal * 60) + segundoFinal;

            int tempoTotal = tudoSegundoFinal - tudoSegundosInicial;


            int diaEvento = tempoTotal / (24 * 3600);
            int restoHoras = tempoTotal % (24 * 3600);
            int horaEvento = restoHoras / (3600);
            int restoMin = restoHoras%3600;
            int minEvento = restoMin / 60;
            int segundoEvento = (restoMin%60);

            Console.WriteLine(diaEvento + " dia(s)");
            Console.WriteLine(horaEvento + " hora(s)");
            Console.WriteLine(minEvento + " minuto(s)");
            Console.WriteLine(segundoEvento + " segundo(s)");



            Console.ReadKey();
        }
    }
}

