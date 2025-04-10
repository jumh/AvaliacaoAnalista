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
            Console.WriteLine("Digite:");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Campo não pode estar em Branco!");
                return;
            }

            string resultado = RemoveDuplicados(input);

            Console.WriteLine($"Resultado: {resultado}");
        }

        static string RemoveDuplicados(string texto)
        {
            if (texto.Length <= 1) return texto;


            StringBuilder sb = new StringBuilder();
            sb.Append(texto[0]); 


            for (int i = 1; i < texto.Length; i++)
            {
                if (texto[i] != texto[i - 1])
                {
                    sb.Append(texto[i]);
                }
            }

            return sb.ToString();
        }
    }
}