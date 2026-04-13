/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite uma string alfanumérica.
    2 - A aplicação deve remover todos os valores duplicados próximos, de forma que não hajam letras/números iguais juntos.
    Exemplo: AAABCCDDD -> Retorno : ABCD
 */

namespace Teste1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = GetAlphanumericStringFromUser();

            var result = RemoveAdjacentDuplicates(input);

            Console.WriteLine($"\nResultado após remover duplicados próximos: {result}");
        }

        static string GetAlphanumericStringFromUser()
        {
            while (true)
            {
                Console.Write("Digite uma string alfanumérica: ");
                
                var input = Console.ReadLine()?.Trim();

                if (!string.IsNullOrEmpty(input) && IsAlphanumeric(input))
                    return input;
                
                Console.WriteLine("Entrada inválida. Por favor, digite uma string alfanumérica.");
            }
        }

        static bool IsAlphanumeric(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetterOrDigit(c))
                    return false;
            }
            return true;
        }


        static string RemoveAdjacentDuplicates(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            var result = new System.Text.StringBuilder();
            
            char previousChar = input[0];
            
            result.Append(previousChar);
            
            for (int i = 1; i < input.Length; i++)
            {
                char currentChar = input[i];
            
                if (currentChar != previousChar)
                {
                    result.Append(currentChar);
                
                    previousChar = currentChar;
                }
            }
            
            return result.ToString();
        }
    }
}