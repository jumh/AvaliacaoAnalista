/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite uma string alfanumérica.
    2 - A aplicação deve remover todos os valores duplicados próximos, de forma que não hajam letras/números iguais juntos.
    Exemplo: AAABCCDDD -> Retorno : ABCD
 */

using System.Text;

namespace Teste1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite uma string alfanumérica:");
            string input = Console.ReadLine();

            string result = RemoveDuplicatesNext(input);
            Console.WriteLine($"Resultado: {result}");
        }

        static string RemoveDuplicatesNext(string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            var result = new StringBuilder();
            result.Append(text[0]);

            for (int i = 1; i < text.Length; i++)
            {
                if (text[i] != text[i - 1])
                    result.Append(text[i]);
            }

            return result.ToString();
        }
    }
}