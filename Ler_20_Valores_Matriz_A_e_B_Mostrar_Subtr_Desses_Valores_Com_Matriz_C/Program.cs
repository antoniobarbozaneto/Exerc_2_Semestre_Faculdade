using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ler_20_Valores_Matriz_A_e_B_Mostrar_Subtr_Desses_Valores_Com_Matriz_C
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] listaA = new int[20];
			int[] listaB = new int[20];
			int[] listaC = new int[20];

			for (int i = 0; i < 20; i++)
			{
				Console.WriteLine("Insira um valor da Matriz A: ");
				listaA[i] = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Insira um valor da Matriz B: ");
				listaB[i] = Convert.ToInt32(Console.ReadLine());

			}
			for (int i = 0; i < 20; i++)
			{
				listaC[i] = listaA[i] - listaB[i];
				Console.WriteLine(i+"O valor de A:" + listaA[i] + " Subtraindo o valor de B:" + listaB[i] + ", é igual a:" + listaC[i]);
			}
			Console.ReadKey();
		}
    }
}
