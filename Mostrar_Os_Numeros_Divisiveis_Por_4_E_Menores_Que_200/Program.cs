using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mostrar_Os_Numeros_Divisiveis_Por_4_E_Menores_Que_200
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 201; i++)
            {
                if ((i % 4 == 0) && (i < 200))
                {
                    Console.WriteLine(i + " É Divisivel por 4 e menor que 200!!!");
                }
            }
        }
    }
}
