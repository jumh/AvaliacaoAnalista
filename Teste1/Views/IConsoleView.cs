namespace Teste1.Views
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
        /// Solicita ao usuário que digite uma string.
        /// </summary>
        /// <returns>String digitada pelo usuário</returns>
        string? RequestInput();

        /// <summary>
        /// Exibe uma mensagem de erro.
        /// </summary>
        /// <param name="errorMessage">Mensagem de erro</param>
        void ShowError(string errorMessage);

        /// <summary>
        /// Exibe o resultado do processamento.
        /// </summary>
        /// <param name="original">String original</param>
        /// <param name="processed">String processada</param>
        void ShowResult(string original, string processed);

        /// <summary>
        /// Pergunta se o usuário deseja processar outra string.
        /// </summary>
        /// <returns>True se deseja continuar, False caso contrário</returns>
        bool AskToContinue();

        /// <summary>
        /// Exibe uma mensagem de despedida.
        /// </summary>
        void ShowGoodbyeMessage();
    }
}

