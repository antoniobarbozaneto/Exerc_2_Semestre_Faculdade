using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volume_da_Caixa_com_Comp_Larg_Alt
{
    class Program
    {
        static void Main(string[] args)
        {
			float c, a, l, v;

			Console.WriteLine("Insira o valor do comprimento da cx: ");
			c = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Insira o valor do altura da cx: ");
			a = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Insira o valor do largura da cx: ");
			l = Convert.ToInt32(Console.ReadLine());

			v = c * l * a;

			Console.WriteLine("O volume da caixa é de: " + v);
		}
    }
}
