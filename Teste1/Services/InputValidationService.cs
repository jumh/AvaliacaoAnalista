namespace Teste1.Services
{
    /// <summary>
    /// Serviço responsável por validar entradas do usuário.
    /// </summary>
    public class InputValidationService : IInputValidationService
    {
        /// <summary>
        /// Valida se a string é alfanumérica (apenas letras e números).
        /// </summary>
        /// <param name="input">String a ser validada</param>
        /// <returns>Tupla com resultado da validação e mensagem de erro</returns>
        public (bool IsValid, string? ErrorMessage) Validate(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return (false, "A entrada não pode ser vazia.");
            }

            // Verifica se contém apenas caracteres alfanuméricos
            if (!input.All(char.IsLetterOrDigit))
            {
                return (false, "A entrada deve conter apenas letras e números (alfanumérico).");
            }

            return (true, null);
        }
    }
}

