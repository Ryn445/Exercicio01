using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade01
{
    public class Exercicio06
    {
        public static void Executar()
        {
            Console.WriteLine("Primeiro Valor");
            Console.WriteLine("Digite True para Verdadeiro");
            Console.WriteLine("Digite False para Falso");
            bool valor1 = bool.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Segundo Valor");
            Console.WriteLine("Digite True para Verdadeiro");
            Console.WriteLine("Digite False para Falso");
            bool valor2 = bool.Parse(Console.ReadLine());
            Console.Clear();


            if (valor1 && valor2)
            {
                Console.WriteLine("Ambos os valores são VERDADEIROS.");
            }
            else
            {
                Console.WriteLine("Pelo menos um dos valores é FALSO.");
            }
            Console.ReadKey();
            Console.Clear();

        }
    }
}
