using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Troca_Valor_de_A_e_B
{
    class Program
    {
        static void Main(string[] args)
        {
			int a, b, trocava, trocavb;

			Console.Write("Informe o valor de A: ");
			a = Convert.ToInt32(Console.ReadLine());
			Console.Write("Informe o valor de B: ");
			b = Convert.ToInt32(Console.ReadLine());

			trocavb = a;
			trocava = b;

			a = trocava;
			b = trocavb;

			Console.WriteLine("O valor de A agora é: " + a);
			Console.WriteLine("O valor de B agora é: " + b);
		}
    }
}
