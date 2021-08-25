using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Aluno_Aprovado_ou_Reprovado
{
    class Program
    {
        static void Main(string[] args)
        {
			double n1 = 0, n2 = 0, n3 = 0, n4 = 0, n5 = 0, media = 0;

			Console.WriteLine("informe a nota: ");
			n1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("informe a nota: ");
			n2 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("informe a nota: ");
			n3 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("informe a nota: ");
			n4 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("informe a nota: ");
			n5 = Convert.ToDouble(Console.ReadLine());

			media = (n1 + n2 + n3 + n4 + n5) / 5;

			if (media >= 5)
			{
				Console.WriteLine("Aluno aprovado com media: " + media);
			}
			else
			{
				Console.WriteLine("Aluno reprovado com media: " + media);
			}
		}
    }
}
