using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcula_Km_por_Litros
{
    class Program
    {
        static void Main(string[] args)
        {
			float v, t, d, Litros_Usados;
			Console.Write("Informe a velocidade média: ");
			v = Convert.ToInt32(Console.ReadLine());
			Console.Write("Informe o tempo de viagem: ");
			t = Convert.ToInt32(Console.ReadLine());
			d = t * v;

			Litros_Usados = (d / 12);

			Console.WriteLine("A Distancia da viagem foi de : " + d + "Km");
			Console.WriteLine("A quantidade de litros usados foi de : " + Litros_Usados + "Litros.");
		}
    }
}
