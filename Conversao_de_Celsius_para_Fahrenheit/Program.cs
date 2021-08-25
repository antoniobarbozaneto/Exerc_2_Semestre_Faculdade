using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversao_de_Celsius_para_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            float F, C;

            Console.WriteLine("Insira a temperatura em grau Celsiu: ");
            C = Convert.ToInt32(Console.ReadLine());

            F = (9 * C + 160) / 5;
            Console.WriteLine("A tempetura em Grau F é: " + F);
        }
    }
}
