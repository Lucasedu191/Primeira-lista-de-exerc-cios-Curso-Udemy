using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;



namespace Cursolista06
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, soma;

            string[] vet = Console.ReadLine().Split(' ');
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);

            soma = 0;

            for (int i = a; i <= b; i++)
            {
                if (i % 2 !=0)
                {
                    soma = soma + i;
                }
            }
            Console.WriteLine(soma);

            Console.ReadLine();

        }
    }
}
