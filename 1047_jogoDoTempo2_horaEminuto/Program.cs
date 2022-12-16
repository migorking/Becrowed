using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace jogoDoTempo2_1047 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int horaIncial, minInicial, horaFinal, minFinal, tempo, horaJogada, minJogado;

            string[] s = Console.ReadLine().Split(' ');

            horaIncial = int.Parse(s[0]);
            minInicial = int.Parse(s[1]);
            horaFinal = int.Parse(s[2]);
            minFinal = int.Parse(s[3]);

            minInicial = minInicial + (horaIncial * 60);
            minFinal = minFinal + (horaFinal * 60);

            tempo = minFinal - minInicial;

            if (tempo <= 0)
            {
                tempo = tempo + (24 * 60);
            }

            horaJogada = (tempo / 60);
            minJogado = (tempo % 60);

            Console.WriteLine($"O JOGO DUROU {horaJogada} HORA(S) E {minJogado} MINUTO(S)");
           

            Console.ReadKey();

        }
    }
}

