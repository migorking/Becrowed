using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace maiorEposicao_1080 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int entradaN, maiorNumero, posicao;

            maiorNumero = 0;
            posicao = 0;

            for (int i = 1; i <= 100; i++)
            {
                entradaN = int.Parse(Console.ReadLine());
                if (entradaN > maiorNumero)
                {
                    maiorNumero = entradaN;
                    posicao = i;
                }
            }

            Console.WriteLine(maiorNumero);
            Console.WriteLine(posicao);

            Console.ReadKey();
        }
    }
}
            
 

