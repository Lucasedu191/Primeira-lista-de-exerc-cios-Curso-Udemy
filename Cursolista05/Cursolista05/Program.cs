using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Cursolista05
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;

            string[] vet = Console.ReadLine().Split(' ');
            x = double.Parse(vet[0], CultureInfo.InvariantCulture);
            y = double.Parse(vet[1], CultureInfo.InvariantCulture);
            z = double.Parse(vet[2], CultureInfo.InvariantCulture);

            if ( x > y && x > z )
            {
                Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));
                
            }
            else if (y > z)
            {
                Console.WriteLine(y.ToString("F2", CultureInfo.InvariantCulture));

            }
            else
            {
                Console.WriteLine(z.ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.ReadLine();
        }
    }
}
