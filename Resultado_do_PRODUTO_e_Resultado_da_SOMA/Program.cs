using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resultado_do_PRODUTO_e_Resultado_da_SOMA
{
    class Program
    {
        static void Main(string[] args)
        {
			double a, b, c, d, p, s;

			a = Convert.ToDouble(Console.ReadLine());
			b = Convert.ToDouble(Console.ReadLine());
			c = Convert.ToDouble(Console.ReadLine());
			d = Convert.ToDouble(Console.ReadLine());

			p = a * c;
			s = b + d;

			Console.WriteLine(p + " " + s);
		}
    }
}
