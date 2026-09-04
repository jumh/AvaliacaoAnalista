using System;

namespace Teste2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro positivo entre 1 e 19: ");
            string entrada = Console.ReadLine();

            // Tenta converter para inteiro
            if (int.TryParse(entrada, out int numero) && numero > 0 && numero < 20)
            {
                gerarfibonacci(numero);
            }
            else
            {
                Console.WriteLine("Entrada inválida! Digite um número inteiro positivo entre 1 e 19.");
            }
        }

        static void gerarfibonacci(int quantidade)
        {
            int a = 1, b = 1;

            Console.Write("Sequência de Fibonacci: ");
            for (int i = 0; i < quantidade; i++)
            {
                Console.Write(a + " ");
                int temp = a + b;
                a = b;
                b = temp;
            }
            Console.WriteLine();
        }
    }
}