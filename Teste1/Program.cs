/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite uma string alfanumérica.
    2 - A aplicação deve remover todos os valores duplicados próximos, de forma que não hajam letras/números iguais juntos.
    Exemplo: AAABCCDDD -> Retorno : ABCD
 */

using System.Text;

namespace Teste1;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma string alfanumérica:");
        var input = Console.ReadLine();

        var result = RemoveDuplicates(input);

        Console.WriteLine($"Resultado: {result}");
    }

    static string RemoveDuplicates(string input)
    {
        if (string.IsNullOrEmpty(input)) return input;

        var previousChar = '\0';
        var output = new StringBuilder();

        foreach (var currentChar in input)
        {
            if (currentChar != previousChar)
            {
                output.Append(currentChar);
                previousChar = currentChar;
            }
        }

        return output.ToString();
    }
}
