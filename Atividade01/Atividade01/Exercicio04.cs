using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade01
{
   public class Exercicio04
    {
        public static void Executar()
        {
            string StringNumeroUm;
            int NumeroUm;
            while (true)
            {
                Console.WriteLine(" Digite um número: ");
                StringNumeroUm = Console.ReadLine();

                if (int.TryParse(StringNumeroUm, out NumeroUm))
                { break; }
                else
                {
                    Console.WriteLine("Digite um número Válido!");
                }
            }

            string StringNumeroDois;
            int NumeroDois;
            while (true)
            {
                Console.WriteLine(" Digite outro número: ");
                StringNumeroDois = Console.ReadLine();
                if (int.TryParse(StringNumeroDois, out NumeroDois))
                { break; }
                else
                {
                    Console.WriteLine("Digite um número Válido!");
                }
            }
            Console.Clear();

            if (NumeroUm == NumeroDois)
            {
                Console.WriteLine($"A soma dos dois número é {NumeroUm + NumeroDois}");
            }
            else
            {
                Console.WriteLine($"A multiplicação dos dois números é {NumeroUm * NumeroDois}");
            }
            Console.ReadKey();
            Console.Clear();


        }
    }
}
