using System.Globalization;

namespace diferenca_1007 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int A, B, C, D, DIFERENCA;

            //Console.Write("Digite seu primeiro numero inteiro: ");
            A = int.Parse(Console.ReadLine());
            // Console.Write("Digite seu segundo numero inteiro: ");
            B = int.Parse(Console.ReadLine());
            // Console.Write("Digite seu terceiro numero inteiro: ");
            C = int.Parse(Console.ReadLine());
           // Console.Write("Digite seu quarto numero inteiro: ");
            D = int.Parse(Console.ReadLine());

            DIFERENCA = (A * B - C * D);

            Console.WriteLine($"DIFERENCA = {DIFERENCA}");

            Console.ReadKey();
        }
    }
}

