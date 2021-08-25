using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Soma_10_Numeros_For
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = 0, v;
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("insira um valor: ");
                v = Convert.ToInt32(Console.ReadLine());
                res = (res + v);
            }
            Console.WriteLine("A soma dos 10 numeros é: " + res);
        }
    }
}
