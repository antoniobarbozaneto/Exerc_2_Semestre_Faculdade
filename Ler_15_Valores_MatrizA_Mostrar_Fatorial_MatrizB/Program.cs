using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ler_15_Valores_MatrizA_Mostrar_Fatorial_MatrizB
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] matrizA = new int[15];
			int[] matrizB = new int[15];

			for (int j = 0; j < 15; j++)
			{
				matrizA[j] = Convert.ToInt32(Console.ReadLine());
				int fat = 1;
				for (int i = matrizA[j]; i >= 1; i--)
				{

					fat = (fat * i);
					matrizB[j] = fat;

				}
			}

			for (int k = 0; k < 15; k++)
			{
				Console.WriteLine("Matriz A - ELEMENTO: " + matrizA[k] + ", Posição [" + k + "] / Matriz B - VALOR FATORIAL: " + matrizB[k] + ", na posição: [" + k + "]");
			}

			Console.ReadKey();
		}
    }
}
