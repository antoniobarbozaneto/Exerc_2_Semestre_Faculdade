﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizA_MatrizB_MatrizC_5_Valores_Cada_MatrizD_15_Valores
{
    class Program
    {
        static void Main(string[] args)
        {
			int aux = 0, aux2 = 0;
			int[] matrizA = new int[5];
			int[] matrizB = new int[5];
			int[] matrizC = new int[5];
			int[] matrizD = new int[15];

			for (int i = 0; i < 15; i++)
			{

				if (i < 5)
				{
					matrizA[i] = i;
					matrizD[i] = matrizA[i];
					Console.WriteLine("Matriz A: " + matrizA[i]);

				}
				else
				{
					if (i < 10)
					{
						matrizB[aux] = i;
						matrizD[i] = matrizB[aux];
						Console.WriteLine("Matriz B: " + matrizB[aux]);
						aux++;

					}
					else
					{
						if (i < 15)
						{
							matrizC[aux2] = i;
							matrizD[i] = matrizC[aux2];
							Console.WriteLine("Matriz C: " + matrizC[aux2]);
							aux2++;
						}
					}
				}
			}
			Console.WriteLine();
			for (int j = 0; j < 15; j++)
			{
				Console.WriteLine("Matriz D: " + matrizD[j]);
			}
			Console.ReadKey();
		}
    }
}
