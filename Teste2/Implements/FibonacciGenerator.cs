using Teste2.Interfaces;

namespace Teste2.Implements
{
    public class FibonacciGenerator : IFibonacciGenerator
    {
        public IEnumerable<int> Generate(int count)
        {
            int a = 1, b = 1;

            for (int i = 0; i < count; i++)
            {
                yield return a;
                (a, b) = (b, a + b);
            }
        }
    }
}
