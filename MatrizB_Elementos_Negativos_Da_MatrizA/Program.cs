﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizB_Elementos_Negativos_Da_MatrizA
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] matrizA = new int[10];
			int[] matrizB = new int[10];

			for (int i = 0; i < 10; i++)
			{
				matrizA[i] = i;
				matrizB[i] = (matrizA[i] * -1);
				Console.WriteLine("Matriz A: POSIÇÃO: " + i + " Valor: " + matrizA[i]);
				Console.WriteLine("Matriz B: POSIÇÃO: " + i + " Valor: " + matrizB[i]);
				Console.WriteLine();
			}


			Console.ReadKey();
		}
    }
}
