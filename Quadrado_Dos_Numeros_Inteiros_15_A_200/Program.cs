using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadrado_Dos_Numeros_Inteiros_15_A_200
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, v;
            for (i = 0; i <= 200; i++)
            {
                v = i;
                v = (v * v);
                Console.WriteLine("o quadrado dos numeros inteiros de 15 a 200 são: " + v);
            }
        }
    }
}
