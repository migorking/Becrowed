namespace produtoSimples_1004 //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int a, b, PROD;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            PROD = a * b;
            Console.WriteLine($"PROD = {PROD}\n");
            //Console.ReadKey();


        }
    }
}

