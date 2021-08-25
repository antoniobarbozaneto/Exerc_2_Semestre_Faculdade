using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_Volume
{
    class Program
    {
        static void Main(string[] args)
        {
			double r, a, v;

			Console.WriteLine("informe a Altura da lata: ");
			a = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("informe o Raio da lata: ");
			r = Convert.ToInt32(Console.ReadLine());

			v = 3.14159 * r * r * a;

			Console.WriteLine("O volume da massa da lata é: " + v);
		}
    }
}
