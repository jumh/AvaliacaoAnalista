using System.Text;

namespace Teste1.Services
{
    /// <summary>
    /// Serviço responsável por remover caracteres duplicados consecutivos de uma string.
    /// </summary>
    public class StringDeduplicationService : IStringDeduplicationService
    {
        /// <summary>
        /// Remove caracteres duplicados consecutivos de uma string.
        /// Exemplo: "AAABCCDDD" -> "ABCD"
        /// </summary>
        /// <param name="input">String de entrada</param>
        /// <returns>String sem duplicados consecutivos</returns>
        public string RemoveConsecutiveDuplicates(string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            if (input.Length == 1)
                return input;

            var result = new StringBuilder();
            result.Append(input[0]);

            for (int i = 1; i < input.Length; i++)
            {
                // Adiciona o caractere apenas se for diferente do anterior
                if (input[i] != input[i - 1])
                {
                    result.Append(input[i]);
                }
            }

            return result.ToString();
        }
    }
}

