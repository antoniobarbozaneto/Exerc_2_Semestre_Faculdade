using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O_Resultado_Quadrado_Da_Diferenca_Do_Primeiro_Valor_Pelo_Segundo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, res;

            Console.Write("Escreva o primeiro valor: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Escreva o segundo valor: ");
            b = Convert.ToInt32(Console.ReadLine());

            res = (a - b);
            res = res * res;

            Console.Write("valor da soma do quadrado da diferença: " + res);

        }
    }
}
