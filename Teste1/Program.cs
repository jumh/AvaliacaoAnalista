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
            Console.Write("Digite uma string alfanumérica: ");
            var input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Entrada inválida. Tente novamente com uma string alfanumérica.");
                return;
            }

            var resultado = RemoverDuplicatasConsecutivas(input);
            Console.WriteLine($"Resultado: {resultado}");
        }

        private static string RemoverDuplicatasConsecutivas(string texto)
        {
            if (string.IsNullOrEmpty(texto) || texto.Length == 1)
                return texto;

            var resultado = new System.Text.StringBuilder();
            char anterior = texto[0];
            resultado.Append(anterior);

            for (int i = 1; i < texto.Length; i++)
            {
                if (texto[i] != anterior)
                {
                    resultado.Append(texto[i]);
                    anterior = texto[i];
                }
            }

            return resultado.ToString();
        }
    }
}