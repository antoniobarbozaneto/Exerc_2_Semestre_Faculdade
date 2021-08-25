using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Lente_de_Contato
{
    class Program
    {
        static void Main(string[] args)
        {

            Double Ge_Esq = 0, Ge_Dir = 0, Gc_Esq = 0, Gc_Dir = 0;
            Double Resto_Ge_Esq = 0, Resto_Ge_Dir = 0, Resto_Gc_Esq = 0, Resto_Gc_Dir = 0;
            Boolean Verif_Valores = false;

            while (Verif_Valores == false)
            {
                Console.WriteLine("- Informe o valores de Grau Esférico e Grau Cilindrico do seus olhos:");
                Console.WriteLine();
                Console.Write(" Insira o Grau eférico do seu olho Esquerdo de -15 a 0: ");
                Ge_Esq = Convert.ToDouble(Console.ReadLine());

                Console.Write(" Insira o Grau esférico do seu olho Direito de -15 a 0: ");
                Ge_Dir = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine();

                Console.Write(" Insira o Grau cilindrico do seu olho Esquerdo de -6 a 0: ");
                Gc_Esq = Convert.ToDouble(Console.ReadLine());

                Console.Write(" Insira o Grau cilindrico do seu olho Direito de -6 a 0: ");
                Gc_Dir = Convert.ToDouble(Console.ReadLine());

                Resto_Ge_Esq = Ge_Esq % 0.25;
                Resto_Ge_Dir = Ge_Dir % 0.25;
                Resto_Gc_Dir = Gc_Dir % 0.25;
                Resto_Gc_Esq = Gc_Esq % 0.25;

                if (Ge_Esq >= -15 && Ge_Esq <= 0 && Ge_Dir >= -15 && Ge_Esq <= 0 && Gc_Esq >= -6 && Gc_Esq <= 0 && Gc_Dir >= -6 && Gc_Esq <= 0) // conferindo se os valores estão corretos!
                {
                    if (Resto_Ge_Esq == 0 && Resto_Ge_Dir == 0 && Resto_Gc_Esq == 0 && Resto_Gc_Dir == 0)
                    {
                        Verif_Valores = true;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine(" Um ou mais valores estão inválidos! Aguarde um instante e insira os valores novamente.");
                        Thread.Sleep(1000);
                        Ge_Esq = 0;
                        Ge_Dir = 0;
                        Gc_Dir = 0;
                        Gc_Esq = 0;
                        Console.Clear();
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine(" Um ou mais valores estão inválidos! Aguarde um instante e insira os valores novamente.");
                    Thread.Sleep(1000);
                    Ge_Esq = 0;
                    Ge_Dir = 0;
                    Gc_Dir = 0;
                    Gc_Esq = 0;
                    Console.Clear();
                }
            }
            if ((Ge_Dir <= -3 && Ge_Dir >= -12 || Ge_Esq <= -3 && Ge_Esq >= -12) && (Gc_Dir >= -2 || Gc_Esq >= -2)) //LENTE PRIME SE TIVER GRAU NO OLHO DIREITO OU ESQUERDO ESTÁ ENTRE -3 E -12 , E GRAU CILINDRICO ATÉ -2.
            {
                Console.WriteLine();
                Console.WriteLine("- A lente Ideal para você é a Lente Prime!!!");
            }
            else if (Gc_Dir != 0 || Ge_Esq != 0)
            {
                if (Ge_Dir < -3 && Ge_Dir > -10) //LENTE PRIME SE TUVER GRAU ESFERICO ENTRE -3 A -10 E CASO TIVER QUALQUER GRAU CILINDRICO.
                {
                    Console.WriteLine();
                    Console.WriteLine("- A lente Ideal para você é a Lente Prime!!!");
                }
                else if (Ge_Esq <= 0 && Ge_Esq >= -15 && Ge_Dir <= 0 && Ge_Dir >= -15 && Gc_Esq >= -5 && Gc_Dir >= -5 && Gc_Esq <= 0 && Gc_Dir <= 0) //LENTE VISION SE O GRAU ESFERICO FOR DE 0 A -15 E GRAU CILINDRICO ATÉ -5
                {
                    Console.WriteLine();
                    Console.WriteLine("- A lente ideal para você é Lente Vision!!!");
                }
            }
            Console.ReadKey();
        }
    }
}
