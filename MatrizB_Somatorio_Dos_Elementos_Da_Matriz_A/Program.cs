﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizB_Somatorio_Dos_Elementos_Da_Matriz_A
{
    class Program
    {
        static void Main(string[] args)
        {
			int resSoma = 0;
			int[] matrizA = new int[20];
			int[] matrizB = new int[20];

			for (int i = 0; i < 20; i++)
			{
				Console.Write("Informe um valor: ");
				matrizA[i] = Convert.ToInt32(Console.ReadLine());

				for (int j = matrizA[i]; j >= 1; j--)
				{
					resSoma = resSoma + j;
					//Console.WriteLine(resSoma);
				}
				matrizB[i] = resSoma;
				resSoma = 0;
			}
			for (int i = 0; i < 20; i++)
			{
				Console.WriteLine("O somatório do elemento: " + matrizA[i] + ", Na posição: [" + i + "] Da Matriz A, é igual a = " + matrizB[i] + ", na posição: [" + i + "], da Matriz B");
			}

			Console.ReadKey();
		}
    }
}
