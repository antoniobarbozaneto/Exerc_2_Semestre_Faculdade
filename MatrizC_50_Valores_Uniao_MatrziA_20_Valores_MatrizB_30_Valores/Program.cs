﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizC_50_Valores_Uniao_MatrziA_20_Valores_MatrizB_30_Valores
{
    class Program
    {
        static void Main(string[] args)
        {
			int aux = 20;
			int[] matrizA = new int[20];
			int[] matrizB = new int[30];
			int[] matrizC = new int[50];

			for (int i = 0; i < 20; i++)
			{
				Console.Write("[Matriz A] informe um valor: ");
				matrizA[i] = Convert.ToInt32(Console.ReadLine());
				matrizC[i] = matrizA[i];
			}
			for (int j = 0; j < 30; j++)
			{
				Console.Write("[Matriz b] informe um valor: ");
				matrizB[j] = Convert.ToInt32(Console.ReadLine());
				matrizC[aux] = matrizB[j];
				aux++;
			}

			for (int k = 0; k < 50; k++)
			{
				Console.WriteLine("Matriz C: " + matrizC[k]);
			}

			Console.ReadKey();
		}
    }
}
