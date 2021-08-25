using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maior_e_Menor_Valor_Utilizando
{
    class Program
    {
        static void Main(string[] args)
        {
			int valor, vmaior, vmenor;

			Console.WriteLine("insira um valor: ");
			valor = Convert.ToInt32(Console.ReadLine());

			vmaior = valor;
			vmenor = valor;

			if (valor > vmaior)
			{
				vmaior = valor;
			}

			if (valor < vmenor)
			{
				vmenor = valor;
			}

			Console.WriteLine("insira um valor: ");
			valor = Convert.ToInt32(Console.ReadLine());
			if (valor > vmaior)
			{
				vmaior = valor;
			}

			if (valor < vmenor)
			{
				vmenor = valor;
			}

			Console.WriteLine("insira um valor: ");
			valor = Convert.ToInt32(Console.ReadLine());
			if (valor > vmaior)
			{
				vmaior = valor;
			}

			if (valor < vmenor)
			{
				vmenor = valor;
			}

			Console.WriteLine("insira um valor: ");
			valor = Convert.ToInt32(Console.ReadLine());
			if (valor > vmaior)
			{
				vmaior = valor;
			}

			if (valor < vmenor)
			{
				vmenor = valor;
			}

			Console.WriteLine("o maior valor inserido foi: " + vmaior);
			Console.WriteLine("o menor valor inserido foi: " + vmenor);
		}
    }
}
