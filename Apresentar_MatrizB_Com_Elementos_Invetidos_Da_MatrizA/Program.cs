﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apresentar_MatrizB_Com_Elementos_Invetidos_Da_MatrizA
{
    class Program
    {
        static void Main(string[] args)
        {
			int aux = 20;
			int[] matrizA = new int[20];
			int[] matrizB = new int[20];


			for (int i = 0; i < 20; i++)
			{
				matrizA[i] = i;
				aux--;
				matrizB[aux] = matrizA[i];
			}

			/////////////MOSTRAR..:
			for (int j = 0; j < 20; j++)
			{
				Console.WriteLine("Matriz A: Posição: " + j + " - Elemento: " + matrizA[j]);
			}

			Console.WriteLine();

			for (int j = 0; j < 20; j++)
			{
				Console.WriteLine("Matriz B  Posição: " + j + " - Elemento: " + matrizB[j]);
			}

			Console.ReadKey();
		}
    }
}
