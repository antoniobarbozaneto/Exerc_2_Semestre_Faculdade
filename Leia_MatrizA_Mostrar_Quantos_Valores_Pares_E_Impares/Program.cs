﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leia_MatrizA_Mostrar_Quantos_Valores_Pares_E_Impares
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] matrizA = new int[30];
			int contPar = 0, contImpar = 0;



			for (int i = 0; i < 30; i++)
			{
				Console.Write("Insira um valor: ");
				matrizA[i] = Convert.ToInt32(Console.ReadLine());
				if (matrizA[i] % 2 == 0)//par
				{
					contPar++;
				}
				else
				{
					contImpar++;
				}
			}
			Console.Write("Quantidade de valores PARES inseridos na matriz foram [" + contPar + "]");
			Console.WriteLine();
			Console.Write("Quantidade de valores IMPARES inseridos na matriz foram [" + contImpar + "]");
			Console.ReadKey();
		}
    }
}
