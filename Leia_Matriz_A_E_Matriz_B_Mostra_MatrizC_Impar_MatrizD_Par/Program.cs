using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leia_Matriz_A_E_Matriz_B_Mostra_MatrizC_Impar_MatrizD_Par
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] matrizA = new int[6];
			int[] matrizB = new int[6];
			int[] matrizC = new int[12];
			int[] matrizD = new int[12];

			Console.WriteLine("Informe os valores da Matriz A: ");
			for (int i = 0; i < 6; i++)
			{
				matrizA[i] = Convert.ToInt32(Console.ReadLine());

				if (matrizA[i] % 2 == 0) //par
				{
					matrizD[i] = matrizA[i];
				}
				else //impar
				{
					matrizC[i] = matrizA[i];
				}

			}
			Console.WriteLine("Informe os valores da Matriz B: ");
			for (int i = 0; i < 6; i++)
			{
				matrizB[i] = Convert.ToInt32(Console.ReadLine());

				if (matrizB[i] % 2 == 0) //par
				{
					if (matrizD[i] == 0)
					{
						//Console.WriteLine("Posição" + i + " esta vazia !!!");
						matrizD[i] = matrizB[i];
					}

					else
					{
						//Console.WriteLine("Posição " + i + " Nao esta vazia !!!");
						int pos = i;
						while (matrizD[pos] != 0)
						{
							//Console.WriteLine("Entrei aqui!");
							pos++;

						}
						matrizD[pos] = matrizB[i];
					}
				}
				else //impar
				{
					if (matrizB[i] % 2 == 1)
					{
						if (matrizC[i] == 0)
						{
							matrizC[i] = matrizB[i];
						}

						else
						{
							int pos = i;
							while (matrizC[pos] != 0)
							{
								pos++;
							}
							matrizC[pos] = matrizB[i];
						}
					}
				}
			}
			Console.WriteLine();
			for (int j = 0; j < 12; j++)
			{
				if (matrizC[j] != 0 || matrizD[j] != 0)
				{
					Console.WriteLine("MATRIZ D - NUMERO PAR: " + matrizD[j]);
					Console.WriteLine();
					Console.WriteLine("MATRIZ C - NUMERO IMPAR: " + matrizC[j]);
					Console.WriteLine();
				}
				else
				{
					j = 13;
				}
			}
			Console.ReadKey();
		}
    }
}
