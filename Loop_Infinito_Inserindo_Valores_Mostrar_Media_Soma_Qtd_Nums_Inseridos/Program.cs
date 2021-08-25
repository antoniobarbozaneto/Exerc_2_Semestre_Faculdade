using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Infinito_Inserindo_Valores_Mostrar_Media_Soma_Qtd_Nums_Inseridos
{
    class Program
    {
        static void Main(string[] args)
        {
			int cont = 0;
			double v = 0, res = 0, media = 0;
			do
			{
				Console.WriteLine("Insira um numero: ");
				v = Convert.ToDouble(Console.ReadLine());

				if (v >= 0)
				{
					res = (res + v);
				}
				else
				{
					Console.WriteLine("saindo do loop infinito...");
				}
				cont = cont + 1;
			} while (v > 0);

			media = (res / cont);

			Console.WriteLine("Valor do somatorio dos numeros positivos: " + res);
			Console.WriteLine("A media dos valores lidos foi: " + media);
			Console.WriteLine("Total de valores lidos foi: " + cont);
		}
    }
}
