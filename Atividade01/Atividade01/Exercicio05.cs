using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade01
{
    public class Exercicio05
    {
        public static void Executar()
        {
            String NumeroString;
            int Numero;
            while (true)
            {
                Console.WriteLine("Digite um número; ");
                NumeroString = Console.ReadLine();

                if (int.TryParse(NumeroString, out Numero))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Por favor dígite um número válido.");
                }
            }

            if (Numero < 0)
            {
                Console.WriteLine($"O Triplo do número digitado é {Numero * 3}");
            }
            else if (Numero > 0)
            {
                Console.WriteLine($"O Doblo do número digitado é {Numero * 2}");
            }
            else
            {
                Console.WriteLine("O número digitado é igual a 0");
            }
            Console.ReadKey();
            Console.Clear();

        }
    }
}
