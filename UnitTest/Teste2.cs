using Teste2;

namespace UnitTest;

public class Teste2
{
    [Theory]
    [InlineData(1, "1")]
    [InlineData(2, "1, 1")]
    [InlineData(3, "1, 1, 2")]
    [InlineData(5, "1, 1, 2, 3, 5")]
    [InlineData(10, "1, 1, 2, 3, 5, 8, 13, 21, 34, 55")]
    public void CorrectSequence(int input, string expected)
    {
        var result = Program.FibonacciResult(input);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void EmptyString_WithZero()
    {
        var result = Program.FibonacciResult(0);

        Assert.Equal(string.Empty, result);
    }

    [Fact]
    public void ReturnsEmptyString_WhithNegative()
    {
        var result = Program.FibonacciResult(-3);

        Assert.Equal(string.Empty, result);
    }
}
