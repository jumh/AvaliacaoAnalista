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
            var input = String.Empty;

            while (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Digite uma string alfanumérica:");
                input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                    Console.WriteLine("Entrada inválida, tente novamente.\n");
            }

            var retorno = RemoverValoresDuplicadosProximos(input);

            Console.WriteLine($"\nResultado:\n{retorno}");
        }

        private static string RemoverValoresDuplicadosProximos(string textoAlfanumerico)
        {
            if (string.IsNullOrEmpty(textoAlfanumerico))
                return textoAlfanumerico;

            var textoFormatado = textoAlfanumerico.Trim();
            var primeiroCaracter = textoFormatado[0];

            var resultado = new StringBuilder();
            resultado.Append(primeiroCaracter);

            for (int i = 1; i < textoFormatado.Length; i++)
            {
                if (textoFormatado[i] != textoFormatado[i - 1])
                    resultado.Append(textoFormatado[i]);
            }

            return resultado.ToString();
        }
    }
}