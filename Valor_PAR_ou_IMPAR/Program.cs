using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valor_PAR_ou_IMPAR
{
    class Program
    {
        static void Main(string[] args)
        {
			int valor;

			Console.WriteLine("Insira um valor: ");
			valor = Convert.ToInt32(Console.ReadLine());

			if (valor % 2 == 0)
			{
				Console.WriteLine("o valor " + valor + " é PAR!!!");
			}
			else
			{
				Console.WriteLine("o valor " + valor + " é IMPAR!!!");
			}
		}
    }
}
