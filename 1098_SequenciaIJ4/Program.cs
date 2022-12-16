using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SequenciaIJ4_1098 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double entradaI, entradaJ;

            entradaI = 0.0;
            

            while( entradaI <= 2)
            {
                entradaJ = entradaI + 1.0;
                if ( entradaI == 0.0 || entradaI == 1.0)
                {

                for ( int i = 0; i < 3; i++)
                {
                    Console.WriteLine($"I={entradaI.ToString(CultureInfo.InvariantCulture)} J={entradaJ.ToString(CultureInfo.InvariantCulture)}");
                    entradaJ += 1.0;
                }
                }
                else
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if(entradaI > 1.9)
                        {
                            Console.WriteLine("I=2 J=" + entradaJ.ToString(CultureInfo.InvariantCulture));
                            entradaJ++;
                        }
                        else
                        {
                            Console.WriteLine($"I={entradaI.ToString("F1",CultureInfo.InvariantCulture)} J={entradaJ.ToString("F1", CultureInfo.InvariantCulture)}");
                            entradaJ++;
                        }
                    }
                }
                entradaI += 0.2;



            }
            

            Console.ReadKey();
        }
    }
}

