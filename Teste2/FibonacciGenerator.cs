public class FibonacciGenerator
{
    public string GenerateSequence(int userInput)
    {
      List<int> fibonacciSequence = CalculateFibonacciSequence(userInput);

      var result = string.Join(", ", fibonacciSequence);

      return result;
    }

    private List<int> CalculateFibonacciSequence(int userInput)
    {
        List<int> sequence = [1, 1];

        int previousLastNumber = sequence[0];
        int lastNumber = sequence[1];
        int currentNumber = 2;

        for (int i = currentNumber; i < userInput; i++)
        {
          currentNumber = previousLastNumber + lastNumber;
          sequence.Add(currentNumber);

          previousLastNumber = lastNumber;
          lastNumber = currentNumber;
        }

        return sequence;
    }
}