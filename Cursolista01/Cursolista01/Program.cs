using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursolista01
{
    class Program
    {
        static void Main(string[] args)
        {
            int volumeInicial, vazao, tempo, volumeFinal;

            volumeInicial = int.Parse(Console.ReadLine());
            vazao = int.Parse(Console.ReadLine());
            tempo = int.Parse(Console.ReadLine());

            if (vazao * tempo > volumeInicial)
            {
                Console.WriteLine("não é possivel");
            }
            else
            {
                volumeFinal = volumeInicial - (vazao * tempo);
                Console.WriteLine(volumeFinal);

            }
            Console.ReadLine();

            

        }
    }
}
