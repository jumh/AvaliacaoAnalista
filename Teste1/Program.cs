/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite uma string alfanumérica.
    2 - A aplicação deve remover todos os valores duplicados próximos, de forma que não hajam letras/números iguais juntos.
    Exemplo: AAABCCDDD -> Retorno : ABCD
 */

using System.Security.Cryptography.X509Certificates;
using System;

namespace Teste1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma string alfanumérica:");
            string input = Console.ReadLine() ?? "Sem valor";

            Console.WriteLine(Program.RemoveAdjacentDuplicates(input));
        }


        public static string RemoveAdjacentDuplicates(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }
            char[] result = new char[input.Length];
            int index = 0;
            result[index++] = input[0];
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != input[i - 1])
                {
                    result[index++] = input[i];
                }
            }
            return new string(result, 0, index);
        }
    }
}