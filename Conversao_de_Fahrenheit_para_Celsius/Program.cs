using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversao_de_Fahrenheit_para_Celsius
{
    class Program
    {
        static void Main(string[] args)
        {
			float F;
			double C;

			Console.WriteLine("Insira a temp em F: ");
			F = Convert.ToInt32(Console.ReadLine());

			C = (F - 32) * (5.0 / 9.0);

			Console.WriteLine("A temp em Celsius é: " + C);
		}
    }
}
