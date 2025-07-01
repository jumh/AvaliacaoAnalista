/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite uma string alfanumérica.
    2 - A aplicação deve remover todos os valores duplicados próximos, de forma que não hajam letras/números iguais juntos.
    Exemplo: AAABCCDDD -> Retorno : ABCD
 */
using System;
using System.Text;

namespace Teste1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a uma string alfanumerica: ");
            string? input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Erro! Entrada vazia.");

                return;
            }

            string result = RemoveDuplicates(input);

            Console.WriteLine("String normalizada: " + result);
            Console.ReadKey();
        }

        static string RemoveDuplicates(string input)
        {
            StringBuilder result = new StringBuilder();
            result.Append(input[0]);

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != input[i - 1]) result.Append(input[i]);
            }
            return result.ToString();
        }
    }
}