using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valor_Tabuada_Laço_For
{
    class Program
    {
        static void Main(string[] args)
        {
			int v, res;
			Console.WriteLine("Informe o valor da tabuada que deseja ver: ");
			v = Convert.ToInt32(Console.ReadLine());

			for (int i = 0; i < 11; i++)
			{
				res = (i * v);
				Console.WriteLine(v + " x " + i + " = " + res);
			}
		}
    }
}
