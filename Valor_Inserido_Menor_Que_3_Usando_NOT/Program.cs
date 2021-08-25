using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valor_Inserido_Menor_Que_3_Usando_NOT
{
    class Program
    {
        static void Main(string[] args)
        {
			int v;
			Console.WriteLine("Insira um valor: ");
			v = Convert.ToInt32(Console.ReadLine());

			if (!(v != 1) || !(v != 2) || !(v != 3))
			{
				Console.WriteLine("O valor inserido é menor que 3!!!");
			}
			else
			{
				Console.WriteLine("o valor inserido não é maior que 3!!!");
			}

		}
    }
}
