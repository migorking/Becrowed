using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace areaCirculo_1002
{

    public class program
    {
        public static void Main(string[] args)
        {
            double r, area;

            
            r = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = 3.14159 * (r * r);


            Console.WriteLine($"A={area.ToString("f4", CultureInfo.InvariantCulture)}");

            Console.ReadKey();



        }
    }
}

