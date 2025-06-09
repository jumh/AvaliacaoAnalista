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
            Console.WriteLine("Porfavor, insira um valor alfanumérico:");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("O valor está vazio ou nulo.");
                return;
            }

            string result = RemoveDuplicates(input);
            Console.WriteLine("Resultado: " + result);
        }

        static string RemoveDuplicates(string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;

            string result = str[0].ToString();
            int i = 1;

            while (i < str.Length)
            {
                if (str[i] != str[i - 1])
                {
                    result += str[i];
                }
                i++;
            }

            return result;
        }

    }
}