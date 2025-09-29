/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite uma string alfanumérica.
    2 - A aplicação deve remover todos os valores duplicados próximos, de forma que não hajam letras/números iguais juntos.
    Exemplo: AAABCCDDD -> Retorno : ABCD
 */
using System;

namespace Teste1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.Write("Digite o caráter: ");
            string? input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Caráter vazia ou nula.");
            }
            else
            {
                Console.WriteLine();
                string result = RemoveConsecutiveDuplicates(input);
                Console.Write("Resultado: " + result);
            }
        }

        static string RemoveConsecutiveDuplicates(string s)
        {
            var sb = new System.Text.StringBuilder();
            char? last = null;

            foreach (char c in s)
            {
                if (last == null || c != last)
                {
                    sb.Append(c);
                    last = c;
                }
            }

            return sb.ToString();
        }
    }
}