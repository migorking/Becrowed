using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DistanciaCarros_1016 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //carro X = 60km/h e carro Y = 90km/hr

            int distancia = int.Parse(Console.ReadLine());

            int tempoAlcance = distancia * 2;

            Console.WriteLine(tempoAlcance + " minutos");

            Console.ReadKey();
        }
    }
}

