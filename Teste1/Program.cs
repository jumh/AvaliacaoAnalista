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
            Console.WriteLine("Digite uma string Alfanumérica:");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("String vazia.");
                return;
            }

            string resultado = input[0].ToString();

            for (int i = 1; i < input.Length; i++)
            {

                if (input[i] != resultado[resultado.Length - 1])
                {
                    resultado += (input[i]);
                }
            }

            Console.WriteLine($"Resultado: {resultado}");
        }
    }
}