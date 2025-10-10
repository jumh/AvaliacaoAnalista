namespace Teste2.Services
{
    /// <summary>
    /// Interface para o serviço de geração de sequência de Fibonacci.
    /// </summary>
    public interface IFibonacciService
    {
        /// <summary>
        /// Gera uma sequência de Fibonacci com a quantidade especificada de termos.
        /// </summary>
        /// <param name="count">Quantidade de termos da sequência</param>
        /// <returns>Lista com a sequência de Fibonacci</returns>
        List<long> GenerateSequence(int count);
    }
}

