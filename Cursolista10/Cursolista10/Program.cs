using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Cursolista10
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double nota1, nota2, nota3, total;

            N = int.Parse(Console.ReadLine());

            for (int i=0; i<N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                nota1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
                nota2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
                nota3 = double.Parse(vet[2], CultureInfo.InvariantCulture);
                total = nota1 + nota2 + nota3;
                Console.WriteLine(total.ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.ReadLine();
        }
    }
}
