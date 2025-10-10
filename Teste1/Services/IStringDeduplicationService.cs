namespace Teste1.Services
{
    /// <summary>
    /// Interface para o serviço de remoção de caracteres duplicados consecutivos.
    /// </summary>
    public interface IStringDeduplicationService
    {
        /// <summary>
        /// Remove caracteres duplicados consecutivos de uma string.
        /// </summary>
        /// <param name="input">String de entrada</param>
        /// <returns>String sem duplicados consecutivos</returns>
        string RemoveConsecutiveDuplicates(string input);
    }
}

