/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite um número.
    2 - A aplicação deve ler essa entrada e garantir que foi digitado um número inteiro, positivo, maior que 0 e menor que 20.
    3 - A aplicação deve gerar uma sequência de Fibonacci com a quantidade de repetições informada pelo usuário.
    Obs: A seguência de Fibonacci segue o padrão 1,1,2,3,5,8 e assim por diante, sendo o próximo número a soma do último número com o seu anterior.
*/

using Teste2.Implements;
using Teste2.Interfaces;

namespace Teste2
{
    internal class Program
    {
        private readonly IInputReader _inputReader;
        private readonly IOutputWriter _outputWriter;
        private readonly INumberValidator _validator;
        private readonly IFibonacciGenerator _generator;

        public Program(
            IInputReader inputReader,
            IOutputWriter outputWriter,
            INumberValidator validator,
            IFibonacciGenerator generator)
        {
            _inputReader = inputReader;
            _outputWriter = outputWriter;
            _validator = validator;
            _generator = generator;
        }

        public void Run()
        {
            _outputWriter.Write("Digite um número inteiro positivo (maior que 0 e menor que 20):");
            var input = _inputReader.Read();

            try
            {
                int number = _validator.Validate(input);
                var sequence = _generator.Generate(number);

                _outputWriter.Write($"Sequência de Fibonacci ({number} termos): {string.Join(", ", sequence)}");
            }
            catch (Exception ex)
            {
                _outputWriter.Write($"Erro: {ex.Message}");
            }
        }

        static void Main(string[] args)
        {
            var app = new Program(
                new ConsoleInputReader(),
                new ConsoleOutputWriter(),
                new NumberValidator(),
                new FibonacciGenerator());

            app.Run();
        }
    }
}