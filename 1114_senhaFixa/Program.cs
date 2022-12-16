using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SenhaFixa_1114 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int senhaFixa = 0;
            

            while (senhaFixa != 2002)
            {

                senhaFixa = Convert.ToInt32(Console.ReadLine());

                if (senhaFixa == 2002)
                {
                    Console.WriteLine("Acesso Permitido");
                }
                else
                {
                    Console.WriteLine("Senha Invalida");
                }

            }

        }
    }
}

