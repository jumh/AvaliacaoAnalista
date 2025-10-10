namespace Teste2.Views
{
    /// <summary>
    /// Interface para a camada de visualização do console.
    /// </summary>
    public interface IConsoleView
    {
        /// <summary>
        /// Exibe uma mensagem de boas-vindas.
        /// </summary>
        void ShowWelcomeMessage();

        /// <summary>
        /// Solicita ao usuário que digite um número.
        /// </summary>
        /// <returns>String digitada pelo usuário</returns>
        string? RequestInput();

        /// <summary>
        /// Exibe uma mensagem de erro.
        /// </summary>
        /// <param name="errorMessage">Mensagem de erro</param>
        void ShowError(string errorMessage);

        /// <summary>
        /// Exibe o resultado da sequência de Fibonacci.
        /// </summary>
        /// <param name="count">Quantidade de termos solicitada</param>
        /// <param name="sequence">Sequência de Fibonacci gerada</param>
        void ShowResult(int count, List<long> sequence);

        /// <summary>
        /// Pergunta se o usuário deseja gerar outra sequência.
        /// </summary>
        /// <returns>True se deseja continuar, False caso contrário</returns>
        bool AskToContinue();

        /// <summary>
        /// Exibe uma mensagem de despedida.
        /// </summary>
        void ShowGoodbyeMessage();
    }
}

