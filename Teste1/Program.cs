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
            Console.WriteLine("Removedor de caracteres duplicados consecutivos");

            Console.Write("Digite o texto que deve ser corrigido: ");
            string text = Console.ReadLine() ?? throw new Exception("Texto não pode ser nulo");

            string newText = "";

            char? lastCharacter = null;
            foreach(char character in text) {
                if(character != lastCharacter) {
                    newText += character;
                }
                lastCharacter = character;
            }
            Console.WriteLine("Texto corrigido: " + newText);
        }
    }
}