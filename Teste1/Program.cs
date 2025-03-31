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
            InputManager inputManager = new();
            DuplicateRemover duplicateRemover = new();

            var userInput = inputManager.GetValidUserInput();
            var result = duplicateRemover.RemoveConsecutiveDuplicates(userInput);

            Console.WriteLine("Resultado: " + result);
        }
    }
}