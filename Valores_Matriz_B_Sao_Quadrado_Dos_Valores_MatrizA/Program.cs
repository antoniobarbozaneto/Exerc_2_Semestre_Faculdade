using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valores_Matriz_B_Sao_Quadrado_Dos_Valores_MatrizA
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] listaA = new int[15];
			int[] listaB = new int[15];

			for (int i = 0; i < 15; i++)
			{
				Console.Write("Insira um valor da Matriz A: ");
				listaA[i] = Convert.ToInt32(Console.ReadLine());

				listaB[i] = listaA[i] * listaA[i];

			}
			for (int i = 0; i < 15; i++)
			{

				Console.WriteLine("O valor de A:" + listaA[i] + " Ao quadrado é igual o valor de B:" + listaB[i]);
			}

			Console.ReadKey();
		}
    }
}
