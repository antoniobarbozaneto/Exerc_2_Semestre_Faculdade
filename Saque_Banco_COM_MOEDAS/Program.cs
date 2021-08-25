using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saque_Banco_MOEDAS_e_NOTAS
{
    class Program
    {
        static void Main(string[] args)
        {
            Double Valor_Saque = 0, Resto = 0;
            Double m50 = 0, m25 = 0, m10 = 0, m5 = 0, m01=0;
            int n100 = 0, n50 = 0, n20 = 0, n10 = 0, n5 = 0, n2 = 0, m1 = 0;            

            Console.Write("Digite o valor que deseja sacar: ");
            Valor_Saque = Convert.ToDouble(Console.ReadLine());

            Resto = Valor_Saque % 100;
            Valor_Saque = Valor_Saque - Resto;
            n100 = Convert.ToInt32(Valor_Saque / 100);
            Valor_Saque = Resto;

            Resto = Valor_Saque % 50;
            n50 = Convert.ToInt32(Valor_Saque - Resto);
            n50 = (n50 / 50);
            Valor_Saque = Resto;

            Resto = Valor_Saque % 20;
            n20 = Convert.ToInt32(Valor_Saque - Resto);
            n20 = (n20 / 20);
            Valor_Saque = Resto;

            Resto = Valor_Saque % 10;          
            n10 = Convert.ToInt32(Valor_Saque - Resto);
            n10 = (n10 / 10);
            Valor_Saque = Resto;

            Resto = Valor_Saque % 5;
            n5 = Convert.ToInt32(Valor_Saque - Resto);
            n5 = (n5 / 5);
            Valor_Saque = Resto;

            Resto = Valor_Saque % 2;
            n2 = Convert.ToInt32(Valor_Saque - Resto);
            n2 = (n2 / 2);
            Valor_Saque = Resto;

            Resto = Valor_Saque % 1;
            m1 = Convert.ToInt32(Valor_Saque - Resto);
            m1 = (m1 / 1);
            Valor_Saque = Resto;

            Resto = Valor_Saque % 0.50;
            m50 = Convert.ToDouble(Valor_Saque - Resto);
            m50 = (m50 / 0.50);
            Valor_Saque = Resto;

            Resto = Valor_Saque % 0.25;
            m25 = Convert.ToDouble(Valor_Saque - Resto);
            m25 = (m25 / 0.25);
            Valor_Saque = Resto;

            Resto = Valor_Saque % 0.10;
            m10 = Convert.ToDouble(Valor_Saque - Resto);
            m10 = (m10 / 0.10);
            Valor_Saque = Resto;

            Resto = Valor_Saque % 0.05;
            m5 = Convert.ToDouble(Valor_Saque - Resto);
            m5 = (m5 / 0.05);
            Valor_Saque = Resto;

            Resto = (Valor_Saque % 0.01);
            m01 = Convert.ToDouble(Valor_Saque - Resto);
            m01 = (m01 / 0.01);
            Valor_Saque = Resto;

            //MOEDAS//////////////////
          //  Console.WriteLine(Resto);
            //NOTAS////////////////////////////////////////////////
            Console.WriteLine("Quantidade de Notas de R$100,00 : " + n100);
            Console.WriteLine("Quantidade de Notas de R$50,00 :" + n50);
            Console.WriteLine("Quantidade de Notas de R$20,00 :" + n20);
            Console.WriteLine("Quantidade de Notas de R$10,00 :" + n10);
            Console.WriteLine("Quantidade de Notas de R$5,00 :" + n5);
            Console.WriteLine("Quantidade de Notas de R$2,00 :" + n2);
            Console.WriteLine();
            //MOEDAS////////////////////////////////////////////////
            Console.WriteLine("Quantidade de Modeas de R$1,00 :" + m1);
            Console.WriteLine("Quantidade de Modeas de R$0,50 :" + m50);
            Console.WriteLine("Quantidade de Moedas de R$0,25 :" + m25);
            Console.WriteLine("Quantidade de Moedas de R$0,10 :" + m10);
            Console.WriteLine("Quantidade de Moedas de R$0,05 :" + m5);
            Console.WriteLine("Quantidade de Moedas de R$0,01:" + m01);
            Console.ReadKey();
        }
    }
}
