using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade01
{
    public class Exercicio02
    {
        public static void Executar()
        {
            Console.WriteLine("Digite seu nome: ");
            string Nome = Console.ReadLine();
            String Sexo = "";
            Console.WriteLine("Escolha seu Sexo");

            while (Sexo != "F" && Sexo != "M")
            {
                Console.WriteLine("Digite F feminino ou M para masculino.");
                Sexo = Console.ReadLine().ToUpper();
                if (Sexo != "F" && Sexo != "M")
                {
                    Console.Clear();
                    Console.WriteLine("Opção invalida! Por favor informe uma opção valida!");
                }
            }

            Console.Clear();
            int EstadoCivil = -111;

            while (EstadoCivil <= 0 || EstadoCivil >= 6)
            {
                Console.WriteLine("Escolha o estado civil:");
                Console.WriteLine("1. Solteiro(a)");
                Console.WriteLine("2. Casado(a)");
                Console.WriteLine("3. Divorciado(a)");
                Console.WriteLine("4. Viúvo(a)");
                Console.WriteLine("5. Outro");
                EstadoCivil = int.Parse(Console.ReadLine());
                if (EstadoCivil <= 0 || EstadoCivil >= 6)
                {
                    Console.Clear();
                    Console.WriteLine("Opção Invalida! Por Favor Repita!");
                }

            }
            Console.Clear();
            int TempoCasada = -1;
            if (Sexo == "F" && EstadoCivil == 2)
            {
                Console.WriteLine("Quanto tempo de Casamento você tem?");
                TempoCasada = int.Parse(Console.ReadLine());

            }
            else
            {
                Console.ReadKey();
                Console.Clear();
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
