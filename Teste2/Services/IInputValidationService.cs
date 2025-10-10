namespace Teste2.Services
{
    /// <summary>
    /// Interface para o serviço de validação de entrada.
    /// </summary>
    public interface IInputValidationService
    {
        /// <summary>
        /// Valida se a entrada é um número válido dentro dos parâmetros esperados.
        /// </summary>
        /// <param name="input">String de entrada a ser validada</param>
        /// <returns>Tupla com resultado da validação, número convertido e mensagem de erro</returns>
        (bool IsValid, int Number, string? ErrorMessage) Validate(string input);
    }
}

