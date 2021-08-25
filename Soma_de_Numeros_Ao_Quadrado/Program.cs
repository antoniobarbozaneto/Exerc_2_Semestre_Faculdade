using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma_de_Numeros_Ao_Quadrado
{
    class Program
    {
        static void Main(string[] args)
        {
			int a, b, c, res;

			Console.WriteLine("Informe o valor de A:");
			a = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Informe o valor de B:");
			b = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Informe o valor de C:");
			c = Convert.ToInt32(Console.ReadLine());

			a = a * a;
			b = b * b;
			c = c * c;

			res = a + b + c;

			Console.WriteLine("O valor da soma dos quadrados da valor de A,B,C é: " + res);
		}
    }
}
