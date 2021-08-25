using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mostrar_Soma_Result_Soma_E_Media_Aritmetica_Dos_Val_Pares_De_50_Ate_70
{
    class Program
    {
        static void Main(string[] args)
        {
			int i, cont = 0;
			double res = 0, rmedia = 0;
			for (i = 50; i < 71; i++)
			{
				if (i % 2 == 0)
				{
					res = res + i;
					cont = cont + 1;
				}
			}
			rmedia = res / cont;
			Console.WriteLine("O Resultado da soma dos numeros pares de 50 ate 70 é: " + res);
			Console.WriteLine("a Media dos numeros pares de 50 ate 70 é: " + rmedia);
		}
    }
}
