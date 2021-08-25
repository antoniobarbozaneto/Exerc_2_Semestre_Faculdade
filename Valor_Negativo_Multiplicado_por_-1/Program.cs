using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valor_Negativo_Multiplicado_por__1
{
    class Program
    {
        static void Main(string[] args)
        {
			int a, b;

			Console.WriteLine("Informe o valor de A: ");
			a = Convert.ToInt32(Console.ReadLine());

			if (a <= 0)
			{
				b = (a * -1);
				Console.WriteLine("O valor de A: " + a + ", multiplicado por -1, é igual a " + b);
			}
			else
			{
				Console.WriteLine("Valor de A: " + a);
			}
		}
    }
}
