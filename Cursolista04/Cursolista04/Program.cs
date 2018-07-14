using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Cursolista04
{
    class Program
    {
        static void Main(string[] args)
        {
            double glicose;
            glicose = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (glicose <= 100.0)
            {
                Console.WriteLine("normal");

            }
            else if (glicose <= 140.0)
            {
                Console.WriteLine("Elevado");
            }
            else
            {
                Console.WriteLine("Diabetes");
            }

            Console.ReadLine();
        }
    }
}
