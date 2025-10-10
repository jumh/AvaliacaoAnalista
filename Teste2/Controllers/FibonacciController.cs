using Teste2.Models;
using Teste2.Services;
using Teste2.Views;

namespace Teste2.Controllers
{
    /// <summary>
    /// Controller responsável por orquestrar o fluxo de geração de sequências de Fibonacci.
    /// </summary>
    public class FibonacciController
    {
        private readonly IConsoleView _view;
        private readonly IInputValidationService _validationService;
        private readonly IFibonacciService _fibonacciService;

        public FibonacciController(
            IConsoleView view,
            IInputValidationService validationService,
            IFibonacciService fibonacciService)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
            _validationService = validationService ?? throw new ArgumentNullException(nameof(validationService));
            _fibonacciService = fibonacciService ?? throw new ArgumentNullException(nameof(fibonacciService));
        }

        /// <summary>
        /// Executa o fluxo principal da aplicação.
        /// </summary>
        public void Run()
        {
            _view.ShowWelcomeMessage();

            bool continueProcessing = true;

            while (continueProcessing)
            {
                ProcessSingleInput();
                continueProcessing = _view.AskToContinue();
            }

            _view.ShowGoodbyeMessage();
        }

        /// <summary>
        /// Processa uma única entrada do usuário.
        /// </summary>
        private void ProcessSingleInput()
        {
            var input = _view.RequestInput();

            if (input == null)
            {
                _view.ShowError("Entrada inválida.");
                return;
            }

            // Valida a entrada
            var (isValid, number, errorMessage) = _validationService.Validate(input);
            
            if (!isValid)
            {
                _view.ShowError(errorMessage ?? "Entrada inválida.");
                return;
            }

            // Gera a sequência de Fibonacci
            var fibonacciInput = new FibonacciInput(number);
            fibonacciInput.Sequence = _fibonacciService.GenerateSequence(number);
            fibonacciInput.IsValid = true;

            // Exibe o resultado
            _view.ShowResult(number, fibonacciInput.Sequence);
        }
    }
}

