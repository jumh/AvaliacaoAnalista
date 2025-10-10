namespace Teste2.Models
{
    /// <summary>
    /// Representa o modelo de entrada para geração de sequência de Fibonacci.
    /// </summary>
    public class FibonacciInput
    {
        public int Count { get; set; }
        public List<long> Sequence { get; set; } = new List<long>();
        public bool IsValid { get; set; }
        public string? ErrorMessage { get; set; }

        public FibonacciInput() { }

        public FibonacciInput(int count)
        {
            Count = count;
        }
    }
}

