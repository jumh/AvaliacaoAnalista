/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite uma string alfanumérica.
    2 - A aplicação deve remover todos os valores duplicados próximos, de forma que não hajam letras/números iguais juntos.
    Exemplo: AAABCCDDD -> Retorno : ABCD
 */



using System.Text.RegularExpressions;

namespace Teste1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool verified = false;
            string? input = string.Empty;
            string expected = string.Empty;
            string output = string.Empty;

            while (!verified)
            {
                Console.WriteLine("Digite uma série de letras e numeros apenas: ");
                input = Console.ReadLine();
                verified = CheckStringRequirements(input);
            }

            input = ClearInput(input);

            for (int i = 0; i < input.Length; i++)
            {
                string actual = input[i].ToString();
                if (!expected.ToLower().Contains(actual.ToLower()))
                {
                    output += actual;
                    expected += actual;
                }
            }
            Console.WriteLine($"Saída: {output}");
        }

        private static string ClearInput(string? input)
        {
            return Regex.Replace(input, "[^a-zA-Z0-9]", "");
        }

        private static bool CheckStringRequirements(string? entrada)
        {
            return !string.IsNullOrEmpty(entrada);
        }
    }
}