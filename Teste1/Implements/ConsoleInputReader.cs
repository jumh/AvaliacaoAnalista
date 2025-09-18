using Teste1.Interfaces;

namespace Teste1.Implements
{
    public class ConsoleInputReader : IInputReader
    {
        public string Read()
        {
            Console.Write("Digite uma string alfanumérica: ");
            return Console.ReadLine() ?? string.Empty;
        }
    }
}
