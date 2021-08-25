using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta_Luz_Consumo
{
    class Program
    {
        static void Main(string[] args)
        {
            double Con_Seg = 0, Con_Ter = 0, Con_Quar = 0, Con_Quin = 0, Con_Sex = 0, Con_Sab = 0, Con_Dom = 0, Con_Media = 0, Con_Soma = 0;

            Console.Write(" Informe quanto foi seu consumo de kWh da sua Conta de luz na Segunda-Feira: ");
            Con_Seg = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Informe quanto foi seu consumo de kWh sua Conta de luz na Terça-Feira: ");
            Con_Ter = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Informe quanto foi seu consumo de kWh sua Conta de luz na Quarta-Feira: ");
            Con_Quar = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Informe quanto foi seu consumo de kWh sua Conta de luz na Quinta-Feira: ");
            Con_Quin = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Informe quanto foi seu consumo de kWh sua Conta de luz na Sexta-Feira: ");
            Con_Sex = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Informe quanto foi seu consumo de kWh sua Conta de luz na Sábado: ");
            Con_Sab = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Informe quanto foi seu consumo de kWh sua Conta de luz na Domingo: ");
            Con_Dom = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Con_Media = (Con_Seg + Con_Ter + Con_Quar + Con_Quin + Con_Sex + Con_Sab + Con_Dom) / 7; 
            Con_Soma = (Con_Seg + Con_Ter + Con_Quar + Con_Quin + Con_Sex + Con_Sab + Con_Dom);

            Console.WriteLine(" O consumo médio durante na semana é de: " + Con_Media + "kWh");
            Console.WriteLine();
            Console.WriteLine(" A soma total do consumo de cada dia da semana é de: " + Con_Soma + "kWh");


            Console.ReadKey();
        }
    }
}
