﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizB_Recebe_Valores_MatrizA_PAR_Multiplicado_Por_2_Impar_Por_1._5
{
    class Program
    {
        static void Main(string[] args)
        {
			double[] matrizA = new double[15];
			double[] matrizB = new double[15];

			Console.WriteLine(" Matriz A: ");
			for (int i = 0; i < 15; i++)
			{
				Console.Write(" Informe um valor: ");
				matrizA[i] = Convert.ToDouble(Console.ReadLine());

				if (matrizA[i] % 2 == 0)
				{
					matrizB[i] = matrizA[i] * 2;
				}
				else
				{
					matrizB[i] = matrizA[i] * 1.5;
				}
			}
			Console.WriteLine();

			Console.WriteLine(" Matriz B: ");
			for (int i = 0; i < 15; i++)
			{
				Console.Write(" Valor: ");
				Console.WriteLine(matrizB[i]);
			}

			Console.ReadKey();
		}
    }
}
