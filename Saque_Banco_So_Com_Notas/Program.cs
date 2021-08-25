using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saque_Banco_So_Com_Notas
{
    class Program
    {
        static void Main(string[] args)
        {
			int valor_saque, resto, n100, n50, n20, n10, n5, n2, n1;

			Console.Write("Informe o valor que desejar sacar: ");
			valor_saque = Convert.ToInt32(Console.ReadLine());

			n100 = valor_saque / 100;
			resto = valor_saque % 100;

			n50 = resto / 50;
			resto = valor_saque % 50;

			n20 = resto / 20;
			resto = valor_saque % 20;

			n10 = resto / 10;
			resto = valor_saque % 10;

			n5 = resto / 5;
			resto = valor_saque % 5;

			n2 = resto / 2;
			resto = valor_saque % 2;

			n1 = resto / 1;
			resto = valor_saque % 1;

			Console.WriteLine("");
			Console.WriteLine("Notas de R$100,00: " + n100);
			Console.WriteLine("Notas de R$50,00: " + n50);
			Console.WriteLine("Notas de R$20,00: " + n20);
			Console.WriteLine("Notas de R$10,00: " + n10);
			Console.WriteLine("Notas de R$5,00: " + n5);
			Console.WriteLine("Notas de R$2,00: " + n2);
			Console.WriteLine("Notas de R$1,00: " + n1);
		}
    }
}
