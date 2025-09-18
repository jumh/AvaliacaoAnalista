using Teste2.Interfaces;

namespace Teste2.Implements
{
    public class ConsoleInputReader : IInputReader
    {
        public string Read() => Console.ReadLine() ?? string.Empty;
    }
}
