using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursolista07
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, quadrado;

            x = int.Parse(Console.ReadLine());

            while ( x != 0)
            {
                quadrado = x * x;
                Console.WriteLine(quadrado);
                x = int.Parse(Console.ReadLine());
            }
            Console.ReadLine();
                

        }
    }
}
