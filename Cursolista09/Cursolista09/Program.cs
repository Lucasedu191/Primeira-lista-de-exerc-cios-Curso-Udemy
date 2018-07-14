using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Cursolista09
{
    class Program
    {
        static void Main(string[] args)
        {
            double tempoTotal, tempoRestante, TempoJogado;
            int N;

            tempoTotal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            N = int.Parse(Console.ReadLine());

            tempoRestante = tempoTotal;

            for (int i = 0; i < N; i++)
            {
                TempoJogado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                tempoRestante = tempoRestante - TempoJogado;
                if (tempoRestante < 0.0)
                {
                    Console.WriteLine("recarregar");
                }
                else
                {
                    Console.WriteLine(tempoRestante);
                }
            }
            Console.ReadLine();
            
            
        }
    }
}
