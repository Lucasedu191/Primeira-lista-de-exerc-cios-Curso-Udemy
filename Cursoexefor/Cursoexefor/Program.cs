using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Cursoexefor
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double x, y, resultado;

            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                x = double.Parse(vet[0], CultureInfo.InvariantCulture);
                y = double.Parse(vet[1], CultureInfo.InvariantCulture);
                if (y == 0)
                {
                    Console.WriteLine("nao existe");
                }
                else
                {
                    resultado = x / y;
                    Console.WriteLine(resultado.ToString("F3", CultureInfo.InvariantCulture));
                }

            }
            Console.ReadLine();
        }
    }
}
