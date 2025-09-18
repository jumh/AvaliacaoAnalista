using Teste2.Interfaces;

namespace Teste2.Implements
{
    public class ConsoleOutputWriter : IOutputWriter
    {
        public void Write(string message) => Console.WriteLine(message);
    }
}
