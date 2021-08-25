using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dois_valores_que_Sao_Divisivel_Por_2_e_3
{
    class Program
    {
        static void Main(string[] args)
        {
			int v1, v2, v3, v4;

			Console.WriteLine("informe o primeiro valor: ");
			v1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("informe o segundo valor: ");
			v2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("informe o terceiro valor: ");
			v3 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("informe o quarto valor: ");
			v4 = Convert.ToInt32(Console.ReadLine());

			if ((v1 % 2 == 0) && (v1 % 3 == 0))
			{
				Console.WriteLine("O primeiro valor: " + v1 + ", é divisível por 2 e por 3");
			}
			else
			{
				Console.WriteLine("O primeiro valor: " + v1 + ", NÃO é divisível por 2 e por 3");
			}

			if ((v2 % 2 == 0) && (v2 % 3 == 0))
			{
				Console.WriteLine("O segundo valor: " + v2 + ", é divisível por 2 e por 3");
			}
			else
			{
				Console.WriteLine("O segundo valor: " + v2 + ", NÃO é divisível por 2 e por 3");
			}

			if ((v3 % 2 == 0) && (v3 % 3 == 0))
			{
				Console.WriteLine("O terceiro valor: " + v3 + ", é divisível por 2 e por 3");
			}
			else
			{
				Console.WriteLine("O terceiro valor: " + v3 + ", NÃO é divisível por 2 e por 3");
			}

			if ((v4 % 2 == 0) && (v4 % 3 == 0))
			{
				Console.WriteLine("O quarto valor: " + v4 + ", é divisível por 2 e por 3");
			}
			else
			{
				Console.WriteLine("O quarto valor: " + v4 + ", NÃO é divisível por 2 e por 3");
			}
		}
    }
}
