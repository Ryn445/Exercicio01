using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade01
{
    public class Exercicio09
    {
        public static void Executar()
        {
            int Sexo;
            while (true)
            {
                Console.WriteLine("Escolha o gênero:");
                Console.WriteLine("1. Masculino");
                Console.WriteLine("2. Feminino");
                string Entrada = Console.ReadLine();

                if ((int.TryParse(Entrada, out Sexo) && (Sexo == 1 || Sexo == 2)))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Incorreto, por favor escolha uma opção valida");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            Console.WriteLine("Digite Sua altura:");
            double Altura = int.Parse(Console.ReadLine());

            if (Sexo == 1)
            {
                Console.Write($"Sua Altura é de {(Altura * 77.7) - 58}");
            }
            else
            {
                Console.Write($"Sua Altura é de {(Altura * 62.1) - 44,7}");
            }
            Console.ReadKey();
            Console.Clear();


        }
    }
}
