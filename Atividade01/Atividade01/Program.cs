using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var opcao = "";
            while (opcao != "X")
            {
                Console.WriteLine("1 - Exercício 1: Soma de dois Números e Comparação com o 3°");
                Console.WriteLine("2 - Exercício 2: Perguntar Nome, Sexo e Estado Civil e se for Casada. ");
                Console.WriteLine("3 - Exercício 3: Receber um número e dizer se é Par ou Ímpar.");
                Console.WriteLine("4 - Exercício 4: Leia dois valores inteiros A e B. Se forem iguais, some-os; caso contrário, multiplique A por B.");
                Console.WriteLine("5 - Exercício 5: Encontre o dobro de um número se ele for positivo ou o triplo se for negativo.");
                Console.WriteLine("6 - Exercício 6: Leia dois valores booleanos (lógicos) e determine se ambos são VERDADEIROS ou FALSOS.");
                Console.WriteLine("7 - Exercício 7: Leia uma variável e some 5 se for par ou some 8 se for ímpar.");
                Console.WriteLine("8 - Exercício 8: Leia três valores inteiros diferentes e mostre-os em ordem decrescente.");
                Console.WriteLine("9 - Exercício 9: Calcule o peso ideal de uma pessoa com base na altura e no sexo.");
                Console.WriteLine("10 - Exercício 10: Calcule o IMC de uma pessoa e indique sua condição de peso.");
                Console.WriteLine("11 - Exercício 11: Calcule o valor a ser pago por um produto com base na forma de pagamento.");
                Console.WriteLine("12 - Exercício 12: Calcule a média de aproveitamento de um aluno e determine seu conceito e situação.");
                Console.WriteLine("X - Para Fechar o Programa");
                Console.Write("Digite o número do exercicio desejado: ");

                opcao = Console.ReadLine().ToUpper();

                Console.Clear();
                switch (opcao)
                {
                    case "1":
                        Exercicio01.Executar();
                        break;
                    case "2":
                        Exercicio02.Executar();
                            break;
                    case "3":
                        Exercicio03.Executar();
                            break;
                    case "4":
                        Exercicio04.Executar();
                        break;
                    case "5":
                        Exercicio05.Executar();
                        break;
                    case "6":
                        Exercicio06.Executar();
                        break;
                    case "7":
                        Exercicio07.Executar();
                        break;
                    case "8":
                        Exercicio08.Executar();
                        break;
                    case "9":
                        Exercicio09.Executar();
                        break;
                    case "10":
                        Exercicio10.Executar();
                        break;
                    case "11":
                        Exercicio11.Executar();
                        break;
                    case "12":
                        Exercicio12.Executar();
                        break;
                    case "X":
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Por favor, escolha um número de exercício válido ou 'X' para fechar o programa");
                        break;
                }
            }

        }
    }
}
