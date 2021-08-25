using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mostrando_Os_Numeros_Impares_De_0_Ate_20
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 20; i = i + 2)
            {
                Console.WriteLine(i + " É IMPAR!!!");
            }
        }
    }
}
