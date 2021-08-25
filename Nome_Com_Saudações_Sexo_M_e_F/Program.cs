using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nome_Com_Saudações_Sexo_M_e_F
{
    class Program
    {
        static void Main(string[] args)
        {
			string nome, sexo;

			Console.WriteLine("informe o nome: ");
			nome = Console.ReadLine();
			Console.WriteLine("informe o Sexo (M)Masculino /(F)Feminio:");
			sexo = Console.ReadLine();

			if ((sexo == "m") || (sexo == "M"))
			{
				Console.WriteLine("Saudações Sr." + nome);

			}
			else
			{
				if ((sexo == "f") || (sexo == "F"))
				{
					Console.WriteLine("Saudações Sra." + nome);
				}
				else
				{
					Console.WriteLine("Sexo invalido!!! ");
				}
			}
    }
}
