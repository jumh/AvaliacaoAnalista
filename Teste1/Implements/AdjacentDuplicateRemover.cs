using System.Text;
using Teste1.Interfaces;

namespace Teste1.Implements
{
    public class AdjacentDuplicateRemover : IStringProcessor
    {
        public string Process(string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            var result = new StringBuilder();
            char? lastChar = null;

            foreach (var current in input)
            {
                if (lastChar != current)
                {
                    result.Append(current);
                    lastChar = current;
                }
            }

            return result.ToString();
        }
    }
}
