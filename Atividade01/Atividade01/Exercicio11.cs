using System;

namespace Atividade01
{
    public class Exercicio11
    {
        public static void Executar()
        {
            Console.Write("Digite o valor do produto: ");
            double PrecoN = double.Parse(Console.ReadLine());
            int opcao = -9999;

            while (opcao < 1 || opcao > 4)
            {
                Console.WriteLine("Escolha o método de pagamento:");
                Console.WriteLine("1 - À vista em dinheiro ou cheque. 10% de desconto.");
                Console.WriteLine("2 - À vista no cartão de crédito. 15% de desconto.");
                Console.WriteLine("3 - Em duas vezes no dinheiro ou cheque.");
                Console.WriteLine("4 - Em duas vezes no cartão de crédito. 10% de Juros.");

                if (int.TryParse(Console.ReadLine(), out opcao) && opcao >= 1 && opcao <= 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Opção incorreta, por favor escolha uma opção válida.");
                }
            }

            double valorPago = 0;

            switch (opcao)
            {
                case 1:
                    valorPago = PrecoN - (PrecoN * 0.10);
                    break;

                case 2:                   
                    valorPago = PrecoN - (PrecoN * 0.15);
                    break;

                case 3: 
                    valorPago = PrecoN;
                    break;

                case 4:
                    valorPago = PrecoN + (PrecoN * 0.10);
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    return;
            }

            Console.WriteLine($"Valor a ser pago: R${valorPago:F2}");
            Console.ReadKey();
            Console.Clear();
        }
    }
}

