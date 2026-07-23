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
            /*logica
            - Olhar cada caractere da entrada
            - Se o caractere lido for igual ao último que já foi colocado no resultado -> ignorar
            - Se for diferente -> adicionar
            */

            // Pede a entrada do usuário
            Console.Write("Digite uma string alfanumérica: ");
            string entrada = Console.ReadLine() ?? "";

            string resultado = "";
            foreach(char c in entrada) {
                if (resultado.Length == 0 || resultado[resultado.Length - 1] != c) {
                    resultado += c;
                }
            }
            Console.WriteLine("Retorno: " + resultado);
        }
    }
}