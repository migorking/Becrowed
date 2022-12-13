using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace salario_1008 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double salary, salaryTotal;
            int numeroFuncionario, horasTrabalhadas;

            numeroFuncionario = Convert.ToInt32(Console.ReadLine());
            horasTrabalhadas = Convert.ToInt32(Console.ReadLine());
            salary = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            salaryTotal = (horasTrabalhadas * salary);


            Console.WriteLine($"NUMBER = {numeroFuncionario}");
            Console.WriteLine($"SALARY = U$ {salaryTotal.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.ReadKey();

        }
    }
}

