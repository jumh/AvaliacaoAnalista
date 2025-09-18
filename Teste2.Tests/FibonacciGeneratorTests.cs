using FluentAssertions;
using Teste2.Implements;

namespace Teste2.Tests
{
    public class FibonacciGeneratorTests
    {
        private readonly FibonacciGenerator _generator = new();

        [Fact]
        public void Generate_ShouldReturnFirstNumbers_WhenCountIsSmall()
        {
            var result = _generator.Generate(5).ToList();

            result.Should().Equal(1, 1, 2, 3, 5);
        }

        [Fact]
        public void Generate_ShouldReturnCorrectSequence_ForLargerInput()
        {
            var result = _generator.Generate(7).ToList();

            result.Should().Equal(1, 1, 2, 3, 5, 8, 13);
        }

        [Fact]
        public void Generate_ShouldReturnEmptySequence_WhenCountIsZero()
        {
            var result = _generator.Generate(0).ToList();

            result.Should().BeEmpty();
        }
    }
}
