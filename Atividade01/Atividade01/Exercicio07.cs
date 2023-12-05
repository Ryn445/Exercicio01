using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade01
{
    public class Exercicio07
    {
        public static void Executar()
        {
            int A;
            while (true)
            {
                Console.WriteLine("Digite um Número:");
                var Num = Console.ReadLine();

                if (int.TryParse(Num, out A))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Digite um número válido");
                }
            }

            if (A % 2 == 0)
            {
                Console.WriteLine($" A soma do número digitado mais 5 é {A + 5}"); /// par
            }
            else
            {
                Console.WriteLine($"A soma do número digitado mais 8 é {A + 8}");/// impar
            }


        }
    }
}
