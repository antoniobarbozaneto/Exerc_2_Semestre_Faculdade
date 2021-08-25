using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leia_MatrizA_So_Aceita_Pares_MatrizB_So_Impares_MatrizC_Uniao_De_Ambas
{
    class Program
    {
        static void Main(string[] args)
        {
			int aux = 6;
			int[] matrizA = new int[6];
			int[] matrizB = new int[6];
			int[] matrizC = new int[12];

			Console.WriteLine("INSIRA VALORES PARES!!! ");

			for (int i = 0; i < 6; i++)
			{
				Console.Write("Informe os valores da Matriz A: ");
				int vPar = Convert.ToInt32(Console.ReadLine());

				if (vPar % 2 == 0)
				{
					matrizA[i] = vPar;
					matrizC[i] = matrizA[i];
				}
				else
				{
					Console.WriteLine("insira novamente um valor PAR para ser guardado na matriz A (Ela nao aceita impares!)");
					i--;
				}
			}
			Console.WriteLine("Todos os valores pares informados foram inseridos na matriz A");
			Thread.Sleep(1000);
			Console.Clear();

			///////////////////////////////////////////////////////////
			///

			Console.WriteLine("INSIRA VALORES IMPARES!!! ");

			for (int i = 0; i < 6; i++)
			{
				Console.Write("Informe os valores da Matriz B: ");
				int vImpar = Convert.ToInt32(Console.ReadLine());

				if (vImpar % 2 == 1)
				{
					matrizB[i] = vImpar;
					matrizC[aux] = matrizB[i];
					aux++;
				}
				else
				{
					Console.WriteLine("insira novamente um valor IMPAR para ser guardado na matriz A (Ela nao aceita impares!)");
					i--;
				}
			}
			Console.WriteLine("Todos os valores pares informados foram inseridos na matriz A");
			Thread.Sleep(1000);
			Console.Clear();
			/////////////////////
			Console.WriteLine("Matriz C : ");
			for (int i = 0; i < 12; i++)
			{
				Console.WriteLine("Posição: [" + i + "] Elemento: " + matrizC[i]);
			}
			Console.ReadKey();
		}
    }
}
