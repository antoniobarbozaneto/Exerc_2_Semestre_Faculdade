using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O_Resultado_Da_Soma_Dos_Numeros_Pares_De_1_A_500
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            for (int i = 0; i < 501; i = i + 2)
            {
                soma = soma + i;
            }
            Console.WriteLine("O resultado da soma de 1 até 500 é: " + soma);
        }
    }
}
