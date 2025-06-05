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
            string entrada = ObterEntradaValida();
            string resultado = RemoverDuplicadosConsecutivos(entrada);
            ExibirResultado(resultado);
        }

        static string ObterEntradaValida()
        {
            while (true)
            {
                Console.Write("Digite uma string alfanumérica (sem espaços): ");
                string entrada = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(entrada) && EhAlfanumerica(entrada))
                {
                    return entrada;
                }

                Console.WriteLine("Entrada inválida. Certifique-se de que digitou apenas letras e números, sem espaços.\n");
            }
        }

        static bool EhAlfanumerica(string texto)
        {
            foreach (char c in texto)
            {
                if (!char.IsLetterOrDigit(c))
                    return false;
            }
            return true;
        }

        static string RemoverDuplicadosConsecutivos(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                return string.Empty;

            var resultado = new StringBuilder();
            resultado.Append(texto[0]);

            for (int i = 1; i < texto.Length; i++)
            {
                if (texto[i] != texto[i - 1])
                {
                    resultado.Append(texto[i]);
                }
            }

            return resultado.ToString();
        }

        static void ExibirResultado(string resultado)
        {
            Console.WriteLine($"\nResultado final sem duplicados consecutivos: {resultado}");
        }
    }
}