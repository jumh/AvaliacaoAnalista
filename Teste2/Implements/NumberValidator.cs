using Teste2.Interfaces;

namespace Teste2.Implements
{
    public class NumberValidator : INumberValidator
    {
        public int Validate(string input)
        {
            if (!int.TryParse(input, out int number))
                throw new ArgumentException("Entrada inválida. Digite um número inteiro.");

            if (number <= 0 || number >= 20)
                throw new ArgumentOutOfRangeException(nameof(input), "Número deve ser > 0 e < 20.");

            return number;
        }
    }
}
