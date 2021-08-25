using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mostrar_Valor_Maior_E_Valor_Menor_Com_Do_While
{
    class Program
    {
        static void Main(string[] args)
        {
			int v, vmaior = 0, vmenor = 0;

			do
			{
				Console.WriteLine("Informe um valor: ");
				v = Convert.ToInt32(Console.ReadLine());

				if (v > vmaior)
				{
					vmaior = v;
				}

				if (v < vmenor)
				{
					vmenor = v;
				}
			} while (v > 0);
			Console.WriteLine("o maior valor inserido foi: " + vmaior);
			Console.WriteLine("o menor valor inserido foi: " + vmenor);
		}
    }
}
