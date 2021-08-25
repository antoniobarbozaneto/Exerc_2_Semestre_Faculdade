using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mostrar_Valor_Maior_que_3_usando_operador_logico_NAO
{
    class Program
    {
        static void Main(string[] args)
        {
			int valor;

			Console.WriteLine("Insira um valor: ");
			valor = Convert.ToInt32(Console.ReadLine());

			if (!(valor > 3))
			{
				Console.WriteLine("valor não é maior que 3!!!");
			}
			else
			{
				Console.WriteLine("valor é maior que 3!!!");
			}
		}
    }
}
