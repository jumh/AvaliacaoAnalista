using Teste1.Models;

namespace Teste1.Services
{
    /// <summary>
    /// Interface para o serviço de validação de entrada.
    /// </summary>
    public interface IInputValidationService
    {
        /// <summary>
        /// Valida se a string de entrada é alfanumérica.
        /// </summary>
        /// <param name="input">String a ser validada</param>
        /// <returns>Resultado da validação com mensagem de erro se houver</returns>
        (bool IsValid, string? ErrorMessage) Validate(string input);
    }
}

