using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SequenciaIJ1_1095 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int seq1, seq2;

            seq1 = 1;
            seq2 = 60;

            while(seq2 >= 0)
            {
                Console.WriteLine($"I={seq1} J={seq2}");
                seq1 += 3;
                seq2 -= 5;
                
            }


            Console.ReadKey();
        }
    }
}

