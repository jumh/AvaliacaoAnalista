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
        static string RemoverDuplicadosProximos(String entrada)
        {
            if (String.IsNullOrEmpty(entrada))
            {
                return "";
            }

            var entradaList = entrada.ToCharArray();
            entrada = "";

            foreach (var caractere in entradaList)
            {
                if (!entrada.EndsWith(caractere.ToString()))
                {
                    entrada += caractere;
                }
            }

            return entrada;
        }
        static void Main(string[] args)
        {
            Console.Write("Digite uma string alfanumérica: ");
            String entrada = Console.ReadLine() ?? "";
            entrada = RemoverDuplicadosProximos(entrada);

            Console.WriteLine("Retorno: " + entrada);
        }
    }
}