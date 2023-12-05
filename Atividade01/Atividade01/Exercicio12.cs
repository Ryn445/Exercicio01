using System;
using System.Collections.Generic;

namespace Atividade01
{
    public class Exercicio12
    {
        public static void Executar()
        {
            Console.WriteLine("Escreva o código do Aluno: ");
            string CodAluno = Console.ReadLine();

            List<double> Notas = new List<double>();
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Digite a {i}° nota do aluno");
                Notas.Add(double.Parse(Console.ReadLine()));
            }

            double Media = (Notas[0] + Notas[1] + Notas[2]) / 3;
            char conceito;

            if (Media >= 9)
                conceito = 'A';
            else if (Media >= 7.5)
                conceito = 'B';
            else if (Media >= 6)
                conceito = 'C';
            else if (Media >= 4)
                conceito = 'D';
            else
                conceito = 'E';

            Console.WriteLine($"Média: {Media:F2}");
            Console.WriteLine($"Conceito: {conceito}");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
