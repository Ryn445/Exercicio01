using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade01
{
   public class Exercicio08
    {
        public static void Executar()
        {
            int numero1, numero2, numero3;

            while (true)
            {
                Console.Write("Digite o 1º número inteiro: ");
                if (int.TryParse(Console.ReadLine(), out numero1))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Por favor, digite um valor inteiro válido.");
                }
            }


            while (true)
            {
                Console.Write("Digite o 2º número inteiro diferente do primeiro: ");
                if (int.TryParse(Console.ReadLine(), out numero2) && numero2 != numero1)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Por favor, digite um valor inteiro válido e diferente do primeiro.");
                }
            }


            while (true)
            {
                Console.Write("Digite o 3º número inteiro diferente dos dois anteriores: ");
                if (int.TryParse(Console.ReadLine(), out numero3) && numero3 != numero1 && numero3 != numero2)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Por favor, digite um valor inteiro válido e diferente dos dois anteriores.");
                }
            }

            // Ordena os números em ordem decrescente
            int[] numeros = { numero1, numero2, numero3 };
            Array.Sort(numeros);
            Array.Reverse(numeros);


            Console.WriteLine("\nNúmeros em ordem decrescente:");
            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }
            Console.ReadKey();
            Console.Clear();

        }
    }
}
