using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valor_Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = 5;
            int b = 1;
            for (int i = valor; i > 1; i--)
            {
                b = (b * i);
                Console.WriteLine(b);
            }
        }
    }
}
