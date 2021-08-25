using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizB_Recebe_Valores_MatrizA_Multiplica_Por_2_Se_For_Impar
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] matrizA = new int[12];
			int[] matrizB = new int[12];

			Console.WriteLine(" Matriz A: ");
			for (int i = 0; i < 12; i++)
			{
				Console.Write(" Informe um valor: ");
				matrizA[i] = Convert.ToInt32(Console.ReadLine());

				if (matrizA[i] % 2 == 1)
				{
					matrizB[i] = matrizA[i] * 2;
				}
				else
				{
					matrizB[i] = matrizA[i];
				}
			}
			Console.WriteLine();

			Console.WriteLine(" Matriz B: ");
			for (int i = 0; i < 12; i++)
			{
				Console.Write(" Valor: ");
				Console.WriteLine(matrizB[i]);
			}

			Console.ReadKey();
		}
    }
}
