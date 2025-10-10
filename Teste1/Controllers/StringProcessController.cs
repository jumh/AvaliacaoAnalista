using Teste1.Models;
using Teste1.Services;
using Teste1.Views;

namespace Teste1.Controllers
{
    /// <summary>
    /// Controller responsável por orquestrar o fluxo de processamento de strings.
    /// </summary>
    public class StringProcessController
    {
        private readonly IConsoleView _view;
        private readonly IInputValidationService _validationService;
        private readonly IStringDeduplicationService _deduplicationService;

        public StringProcessController(
            IConsoleView view,
            IInputValidationService validationService,
            IStringDeduplicationService deduplicationService)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
            _validationService = validationService ?? throw new ArgumentNullException(nameof(validationService));
            _deduplicationService = deduplicationService ?? throw new ArgumentNullException(nameof(deduplicationService));
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

            var stringInput = new StringInput(input);

            // Valida a entrada
            var (isValid, errorMessage) = _validationService.Validate(input);
            
            if (!isValid)
            {
                _view.ShowError(errorMessage ?? "Entrada inválida.");
                return;
            }

            // Processa a string
            stringInput.ProcessedValue = _deduplicationService.RemoveConsecutiveDuplicates(input);
            stringInput.IsValid = true;

            // Exibe o resultado
            _view.ShowResult(stringInput.OriginalValue, stringInput.ProcessedValue);
        }
    }
}

