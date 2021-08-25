using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mostrar_a_Diferenca_do_Menor_entre_A_e_B
{
    class Program
    {
        static void Main(string[] args)
        {
			int a, b, c;

			Console.WriteLine("Informe um valor de A: ");
			a = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Informe um valor de B: ");
			b = Convert.ToInt32(Console.ReadLine());

			if (a > b)
			{
				c = (a - b);
			}
			else
			{
				c = (b - a);
			}

			Console.WriteLine("O valor da diferença do Menor é: " + c);

		}
	}
}
