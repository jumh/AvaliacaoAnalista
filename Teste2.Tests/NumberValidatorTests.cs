using FluentAssertions;
using Teste2.Implements;

namespace Teste2.Tests
{
    public class NumberValidatorTests
    {
        private readonly NumberValidator _validator = new();

        [Theory]
        [InlineData("1", 1)]
        [InlineData("5", 5)]
        [InlineData("19", 19)]
        public void Validate_ShouldReturnNumber_WhenValidInput(string input, int expected)
        {
            var result = _validator.Validate(input);
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData("0")]
        [InlineData("20")]
        [InlineData("-3")]
        public void Validate_ShouldThrowArgumentOutOfRange_WhenOutOfRange(string input)
        {
            var act = () => _validator.Validate(input);
            act.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Theory]
        [InlineData("abc")]
        [InlineData("")]
        [InlineData(" ")]
        public void Validate_ShouldThrowArgumentException_WhenNotANumber(string input)
        {
            var act = () => _validator.Validate(input);
            act.Should().Throw<ArgumentException>();
        }
    }
}
