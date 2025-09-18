using Teste1.Interfaces;

namespace Teste1.Implements
{
    public class ConsoleOutputWriter : IOutputWriter
    {
        public void Write(string message)
        {
            Console.WriteLine($"Resultado: {message}");
        }
    }
}
