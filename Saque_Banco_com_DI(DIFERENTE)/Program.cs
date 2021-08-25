using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saque_Banco_com_DIV_e_MOD__DIFERENTE_
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor_saque;
            int n100,n50,n20,n10,n5,n2,n1;

            Console.Write("Qual valor desejar sacar: ");

            valor_saque = Convert.ToInt32(Console.ReadLine());

            n100 = valor_saque / 100;

            n50 = (valor_saque - n100 * 100) / 50;          

            n20 = (valor_saque - n100 * 100 - n50 * 50) / 20;

            n10 = (valor_saque - n100 * 100 - n50 * 50 - n20 * 20) / 10;

            n5 = (valor_saque - n100 * 100 - n50 * 50 - n20 * 20 - n10 * 10) / 5;

            n2 = (valor_saque - n100 * 100 - n50 * 50 - n20 * 20 - n10 * 10 - n5 * 5) / 2;

            n1 = (valor_saque - n100 * 100 - n50 * 50 - n20 * 20 - n10 * 10 - n5 * 5 - n2 * 2) / 1;

            Console.WriteLine("Nota de 100: " + n100);
            Console.WriteLine("Nota de 50: " + n50);
            Console.WriteLine("Nota de 20: " + n20);
            Console.WriteLine("Nota de 10: " + n10);
            Console.WriteLine("Nota de 5: " + n5);
            Console.WriteLine("Nota de 2: " + n2);
            Console.WriteLine("Nota de 1: " + n1);

            Console.ReadKey();
        }
    }
}
