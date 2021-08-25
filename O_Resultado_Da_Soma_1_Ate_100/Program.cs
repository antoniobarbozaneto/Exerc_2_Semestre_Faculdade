using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O_Resultado_Da_Soma_1_Ate_100
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 101; i++)
            {
                res = (res + i);
            }
            Console.WriteLine("O resultado da soma de 1 até 100 é: " + res);
        }
    }
}
