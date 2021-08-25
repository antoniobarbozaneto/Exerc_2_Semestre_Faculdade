using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ler_10_Valores_Mostrar_Os_Valores_Com_Vetor
{
    class Program
    {
        static void Main(string[] args)
        {

			int[] lista = new int[10];

			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine("Insira um valor: ");
				lista[i] = Convert.ToInt32(Console.ReadLine());
			}
			Console.WriteLine("Mostrando: ");
			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine(lista[i]);
			}
		}
    }
}
