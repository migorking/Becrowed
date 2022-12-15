using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsumoDeCombustivel_1017 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int consumo, tempoViagem, velocidaeMedia;

            consumo = 12;
            tempoViagem = Convert.ToInt32(Console.ReadLine());
            velocidaeMedia= Convert.ToInt32(Console.ReadLine());

            double consumoViagem = (Convert.ToDouble(tempoViagem * velocidaeMedia) / consumo);

            Console.WriteLine(consumoViagem.ToString("F3", CultureInfo.InvariantCulture));
            Console.ReadKey();

        }
    }
}

