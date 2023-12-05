using System;

namespace Atividade01
{
    public class Exercicio10
    {
        public static void Executar()
        {
            Console.WriteLine("Digite sua altura: ");
            double Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu Peso");
            double Peso = double.Parse(Console.ReadLine());

            double indice = Peso / Math.Pow(Altura, 2);
            Console.WriteLine($"Seu IMC é {indice:F2}");

            if (indice <= 18.5)
            {
                Console.WriteLine("Você está abaixo do peso!");
            }
            else if (indice <= 25)
            {
                Console.WriteLine("Seu peso está normal");
            }
            else if (indice <= 30)
            {
                Console.WriteLine("Você está acima do peso, faça uma dieta!");
            }
            else
            {
                Console.WriteLine("Você está obeso, feche essa boca!");
            }
            Console.ReadKey();
            Console.Clear();

        }

    }
}
