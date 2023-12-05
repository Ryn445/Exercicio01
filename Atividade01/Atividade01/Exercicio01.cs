using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade01
{
    public class Exercicio01
    {
        public static void Executar()
        {
            Console.WriteLine("Digite o primeiro número: ");
            int NumeroA = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Digite o segundo número: ");
            int NumeroB = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Digite o terceiro número: ");
            int NumeroC = int.Parse(Console.ReadLine());
            Console.Clear();

            int Soma = NumeroA + NumeroB;

            Console.WriteLine($"A soma dos números {NumeroA} e {NumeroB} é {Soma}");

            if (Soma > NumeroC)
            {
                Console.WriteLine($"Então a soma dos dois primeiros números é maior que o número {NumeroC}");
            }
            else if (Soma < NumeroC)
            {
                Console.WriteLine($"Então a soma dos dois primeiros números é menor que o número {NumeroC}");
            }
            else if (Soma == NumeroC)
            {
                Console.WriteLine($"Então a soma dos dois primeiros números é igual ao número {NumeroC} ");
            }
            else
            {
                Console.WriteLine("Erro.");
            }
            Console.ReadKey();
            Console.Clear();

        }
    }
}
