namespace Teste1.Models
{
    /// <summary>
    /// Representa o modelo de entrada de string alfanumérica.
    /// </summary>
    public class StringInput
    {
        public string OriginalValue { get; set; } = string.Empty;
        public string ProcessedValue { get; set; } = string.Empty;
        public bool IsValid { get; set; }
        public string? ErrorMessage { get; set; }

        public StringInput() { }

        public StringInput(string originalValue)
        {
            OriginalValue = originalValue;
        }
    }
}

