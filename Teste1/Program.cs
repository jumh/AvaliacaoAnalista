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
            string entrada = SolicitarStringEntrada();
            string resultado = RemoverCaracteresDuplicadosConsecutivos(entrada);

            Console.WriteLine($"A String de entrada foi {entrada}");
            Console.WriteLine($"Após remoção de duplicados consecutivos obtivemos o resultado {resultado}");
        }

        static string SolicitarStringEntrada()
        {
            string entrada;

            while (true)
            {
                Console.WriteLine("Por favor, entre com uma string alfanumérica aleatória!");
                entrada = Console.ReadLine();
             
                string mensagemErro = string.IsNullOrEmpty(entrada) ? "Erro: A string não pode ser vazia. Tente novamente." : null;

                if (!string.IsNullOrEmpty(mensagemErro))
                {
                    Console.WriteLine(mensagemErro);
                    Console.WriteLine();
                }
                else
                {
                    break;
                }
            }
            
            return entrada;
        }

        static string RemoverCaracteresDuplicadosConsecutivos(string input)
        {
            // Primeiro caracter entra direto, e depois avalia apenas os que são diferentes do anterior
            return new string(input
                              .Where((c, index) => index == 0 || c != input[index - 1])
                              .ToArray());
        }

    }
}