using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_MOD_e_DIV
{
    class Program
    {
        static void Main(string[] args)
        {
			int resDiv, resMod, valor1, valor2;

			Console.Write("Digite um numero: ");
			valor1 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Digite outro numero numero: ");
			valor2 = Convert.ToInt32(Console.ReadLine());

			resDiv = (valor1 / valor2); // COMO AS DUAS VARIAVEIS SAO INTEIRAS ELA ENTENDE COMO DIV. SE FOSSE FLOAT ELA FAZERIA A CONVENCIONAL.		
			resMod = (valor1 % valor2);

			Console.WriteLine("Resposta DIV é: " + resDiv);
			Console.WriteLine("Resposta MOD é: " + resMod);
		}
    }
}
