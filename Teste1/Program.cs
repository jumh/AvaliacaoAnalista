/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite uma string alfanumérica.
    2 - A aplicação deve remover todos os valores duplicados próximos, de forma que não hajam letras/números iguais juntos.
    Exemplo: AAABCCDDD -> Retorno : ABCD
 */

namespace Teste1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Boa sorte!");
            Console.WriteLine("Digite uma string alfanumérica:");
            string input = Console.ReadLine();
            string result = RemoveDuplicates(input);
            Console.WriteLine("Resultado: " + result);  
        }

        static string RemoveDuplicates(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            char[] chars = input.ToCharArray();
            int writeIndex = 1;

            for (int i = 1; i < chars.Length; i++)
            {
                if (chars[i] != chars[i - 1])
                {
                    chars[writeIndex] = chars[i];
                    writeIndex++; 
                }
            }

            return new string(chars, 0, writeIndex);
        }
    }
}