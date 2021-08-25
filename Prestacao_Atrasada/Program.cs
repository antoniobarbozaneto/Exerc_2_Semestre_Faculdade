using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestacao_Atrasada
{
    class Program
    {
        static void Main(string[] args)
        {
			float v, tx, t, vp;
			Console.Write("Informe o valor: ");
			v = Convert.ToInt32(Console.ReadLine());
			Console.Write("Informe a taxa: ");
			tx = Convert.ToInt32(Console.ReadLine());

			Console.Write("Informe qnts dias está em atraso: ");
			t = Convert.ToInt32(Console.ReadLine());

			vp = v + (v * (tx / 100) * t);
			Console.WriteLine("P valor da Valor da prestação em atraso é de: " + vp);
		}
    }
}
