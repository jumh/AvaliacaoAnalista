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
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma string alfanumérica");
            var input = Console.ReadLine();

            while (string.IsNullOrEmpty(input) || !input.All(char.IsLetterOrDigit))
            {
                Console.WriteLine("Por favor, digite uma string alfanumérica válida");
                input = Console.ReadLine();
            }

            var result = RemoveDuplicated(input);

            Console.WriteLine($"Resultado: {result}");
        }


        static string RemoveDuplicated(string input)
        {
            if (input.Length < 2)
                return input;

            StringBuilder sb = new StringBuilder();
            sb.Append(input[0]);

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != input[i - 1])
                {
                    sb.Append(input[i]);
                }
            }

            return sb.ToString();
        }
    }


    public class Pessoa
    {
        public string Nome { get; set; }
        public DateTime Idade { get; set; }
        public string CPF { get; set; }

    }
}