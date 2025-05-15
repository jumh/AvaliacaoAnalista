/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite uma string alfanumérica.
    2 - A aplicação deve remover todos os valores duplicados próximos, de forma que não hajam letras/números iguais juntos.
    Exemplo: AAABCCDDD -> Retorno : ABCD
 */

using System.Text;

namespace Teste1;

public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um texto alfanumérico para remover duplicatas consecutivas: ");

        string userInputText = Console.ReadLine() ?? string.Empty;

        if (string.IsNullOrWhiteSpace(userInputText))
        {
            Console.WriteLine("Sem entrada de dados");
        }
        else
        {
            string formattedInputValue = RemoveDuplicateLetters(userInputText);
            Console.WriteLine("Resultado: " + formattedInputValue);
        }
    }

    public static string RemoveDuplicateLetters(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;

        var finalResult = new StringBuilder();
        char lastLetter = input[0];

        finalResult.Append(lastLetter);

        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] != lastLetter)
            {
                finalResult.Append(input[i]);
                lastLetter = input[i];
            }
        }

        return finalResult.ToString();
    }
}