/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite uma string alfanumérica.
    2 - A aplicação deve remover todos os valores duplicados próximos, de forma que não hajam letras/números iguais juntos.
    Exemplo: AAABCCDDD -> Retorno : ABCD
 */

using Teste1.Interfaces;
using Teste1.Implements;

namespace Teste1
{
    internal class Program
    {
        private readonly IInputReader _inputReader;
        private readonly IStringProcessor _processor;
        private readonly IOutputWriter _outputWriter;

        public Program(IInputReader inputReader, IStringProcessor processor, IOutputWriter outputWriter)
        {
            _inputReader = inputReader;
            _processor = processor;
            _outputWriter = outputWriter;
        }

        private void Run()
        {
            var input = _inputReader.Read();
            var output = _processor.Process(input);
            _outputWriter.Write(output);
        }

        static void Main(string[] args)
        {
            var app = new Program(
                new ConsoleInputReader(),
                new AdjacentDuplicateRemover(),
                new ConsoleOutputWriter());

            app.Run();
        }
    }
}