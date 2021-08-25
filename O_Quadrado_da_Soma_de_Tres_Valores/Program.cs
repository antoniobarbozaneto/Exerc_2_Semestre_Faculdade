using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O_Quadrado_da_Soma_de_Tres_Valores
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

			res = a + b + c;
			res = res * res;
			Console.WriteLine("O valor da soma dos quadrados da valor de A,B,C é: " + res);
		}
    }
}
