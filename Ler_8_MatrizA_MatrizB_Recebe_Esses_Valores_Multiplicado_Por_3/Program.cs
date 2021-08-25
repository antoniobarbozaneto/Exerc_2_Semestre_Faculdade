using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ler_8_MatrizA_MatrizB_Recebe_Esses_Valores_Multiplicado_Por_3
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] listaA = new int[8];
			int[] listaB = new int[8];

			for (int i = 0; i < 8; i++)
			{
				Console.WriteLine("Insira um valor: ");
				listaA[i] = Convert.ToInt32(Console.ReadLine());
			}
			Console.WriteLine("Mostrando: ");
			for (int i = 0; i < 8; i++)
			{
				listaB[i] = listaA[i] * 3;
				Console.WriteLine(listaB[i]);
			}
		}
    }
}
