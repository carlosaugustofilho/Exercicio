using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    using System;

    class Program
    {
        static void Main()
        {
            int termo1 = 0;
            int termo2 = 1;
            int termo3 = 0;

            Console.WriteLine("Bem-vindo à consulta da sequência de Fibonacci!");
            Console.WriteLine("A sequência de Fibonacci é uma série de números em que cada número é a soma dos dois anteriores.");
            Console.WriteLine("Por exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, ...");
            Console.WriteLine();

            while (true)
            {
                Console.Write("Digite um número inteiro positivo (ou digite 'sair' para encerrar o programa): ");
                string input = Console.ReadLine();

                if (input.ToLower() == "sair")
                {
                    break;
                }

                if (!int.TryParse(input, out int valor) || valor < 0)
                {
                    Console.WriteLine("Por favor, digite um número inteiro positivo válido.");
                    Console.WriteLine();
                    continue;
                }

                while (valor > termo3)
                {
                    termo3 = termo1 + termo2;
                    termo1 = termo2;
                    termo2 = termo3;
                }

                if (valor == 0 || valor == 1 || valor == termo3)
                {
                    Console.WriteLine("O número {0} faz parte da sequência de Fibonacci.", valor);
                }
                else
                {
                    Console.WriteLine("O número {0} não faz parte da sequência de Fibonacci.", valor);
                }

                Console.WriteLine();
            }

            Console.WriteLine("Obrigado por usar o programa! Pressione qualquer tecla para encerrar...");
            Console.ReadKey();
        }
    }
}
