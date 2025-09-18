using FluentAssertions;
using Teste1.Implements;

namespace Teste1.Tests
{
    public class AdjacentDuplicateRemoverTests
    {
        private readonly AdjacentDuplicateRemover _sut;

        public AdjacentDuplicateRemoverTests()
        {
            _sut = new AdjacentDuplicateRemover();
        }

        [Theory]
        [InlineData("AAABCCDDD", "ABCD")]
        [InlineData("1122334455", "12345")]
        [InlineData("AABBCC", "ABC")]
        [InlineData("ABABAB", "ABABAB")]
        [InlineData("ZZZZZ", "Z")]
        [InlineData("", "")]
        [InlineData(null, "")]
        public void Process_ShouldRemoveAdjacentDuplicates(string input, string expected)
        {
            var result = _sut.Process(input);

            result.Should().Be(expected);
        }
    }
}
