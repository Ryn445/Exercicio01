
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade01
{
    public class Exercicio03
    {
        public static void Executar()
        {
            string Entrada;
            int Numero;
            while (true)
            {
                Console.WriteLine("Digite um número inteiro para saber se é par ou ímpar.");
                Entrada = Console.ReadLine();


                if (int.TryParse(Entrada, out Numero))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Número inválido, por favor digite novamente");
                    Console.WriteLine("Aperte qualquer tecla para continuar.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            if (Numero % 2 == 0)
            {
                Console.WriteLine("O número é par.");
            }
            else
            {
                Console.WriteLine("O número é impar");
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
