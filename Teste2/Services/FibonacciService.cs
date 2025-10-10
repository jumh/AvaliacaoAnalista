namespace Teste2.Services
{
    /// <summary>
    /// Serviço responsável por gerar sequências de Fibonacci.
    /// </summary>
    public class FibonacciService : IFibonacciService
    {
        /// <summary>
        /// Gera uma sequência de Fibonacci com a quantidade especificada de termos.
        /// A sequência segue o padrão: 1, 1, 2, 3, 5, 8, 13, 21...
        /// </summary>
        /// <param name="count">Quantidade de termos da sequência (deve ser maior que 0)</param>
        /// <returns>Lista com a sequência de Fibonacci</returns>
        public List<long> GenerateSequence(int count)
        {
            if (count <= 0)
                return new List<long>();

            var sequence = new List<long>();

            if (count >= 1)
                sequence.Add(1);

            if (count >= 2)
                sequence.Add(1);

            for (int i = 2; i < count; i++)
            {
                long next = sequence[i - 1] + sequence[i - 2];
                sequence.Add(next);
            }

            return sequence;
        }
    }
}

