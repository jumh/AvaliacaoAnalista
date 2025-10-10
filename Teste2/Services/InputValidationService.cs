namespace Teste2.Services
{
    /// <summary>
    /// Serviço responsável por validar entradas do usuário.
    /// </summary>
    public class InputValidationService : IInputValidationService
    {
        private const int MinValue = 1;
        private const int MaxValue = 19;

        /// <summary>
        /// Valida se a entrada é um número inteiro positivo entre 1 e 19.
        /// </summary>
        /// <param name="input">String de entrada</param>
        /// <returns>Tupla com resultado da validação, número convertido e mensagem de erro</returns>
        public (bool IsValid, int Number, string? ErrorMessage) Validate(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return (false, 0, "A entrada não pode ser vazia.");
            }

            if (!int.TryParse(input, out int number))
            {
                return (false, 0, "A entrada deve ser um número inteiro válido.");
            }

            if (number <= 0)
            {
                return (false, 0, "O número deve ser maior que 0.");
            }

            if (number >= 20)
            {
                return (false, 0, "O número deve ser menor que 20.");
            }

            return (true, number, null);
        }
    }
}

