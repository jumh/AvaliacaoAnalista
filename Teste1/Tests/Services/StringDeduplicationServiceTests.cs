using FluentAssertions;
using Teste1.Services;

namespace Teste1.Tests.Services
{
    /// <summary>
    /// Testes para o serviço de remoção de caracteres duplicados consecutivos.
    /// </summary>
    public class StringDeduplicationServiceTests
    {
        private readonly StringDeduplicationService _service;

        public StringDeduplicationServiceTests()
        {
            _service = new StringDeduplicationService();
        }

        [Fact(DisplayName = "Deve remover caracteres duplicados consecutivos corretamente")]
        public void RemoveConsecutiveDuplicates_ValidInput_RemovesDuplicates()
        {
            // Arrange
            var input = "AAABCCDDD";

            // Act
            var result = _service.RemoveConsecutiveDuplicates(input);

            // Assert
            result.Should().Be("ABCD");
        }

        [Fact(DisplayName = "Deve retornar string vazia quando entrada é vazia")]
        public void RemoveConsecutiveDuplicates_EmptyString_ReturnsEmpty()
        {
            // Arrange
            var input = "";

            // Act
            var result = _service.RemoveConsecutiveDuplicates(input);

            // Assert
            result.Should().BeEmpty();
        }

        [Fact(DisplayName = "Deve retornar string vazia quando entrada é null")]
        public void RemoveConsecutiveDuplicates_NullString_ReturnsEmpty()
        {
            // Arrange
            string? input = null;

            // Act
            var result = _service.RemoveConsecutiveDuplicates(input!);

            // Assert
            result.Should().BeEmpty();
        }

        [Fact(DisplayName = "Deve retornar mesmo caractere quando string tem apenas um caractere")]
        public void RemoveConsecutiveDuplicates_SingleCharacter_ReturnsSameCharacter()
        {
            // Arrange
            var input = "A";

            // Act
            var result = _service.RemoveConsecutiveDuplicates(input);

            // Assert
            result.Should().Be("A");
        }

        [Fact(DisplayName = "Deve manter string quando não há duplicados consecutivos")]
        public void RemoveConsecutiveDuplicates_NoDuplicates_ReturnsSameString()
        {
            // Arrange
            var input = "ABCD";

            // Act
            var result = _service.RemoveConsecutiveDuplicates(input);

            // Assert
            result.Should().Be("ABCD");
        }

        [Fact(DisplayName = "Deve processar strings alfanuméricas mistas corretamente")]
        public void RemoveConsecutiveDuplicates_AlphanumericString_RemovesDuplicatesCorrectly()
        {
            // Arrange
            var input = "aaa123bbb456ccc";

            // Act
            var result = _service.RemoveConsecutiveDuplicates(input);

            // Assert
            result.Should().Be("a123b456c");
        }

        [Fact(DisplayName = "Deve processar string com apenas números")]
        public void RemoveConsecutiveDuplicates_NumericString_RemovesDuplicatesCorrectly()
        {
            // Arrange
            var input = "111222333";

            // Act
            var result = _service.RemoveConsecutiveDuplicates(input);

            // Assert
            result.Should().Be("123");
        }

        [Fact(DisplayName = "Deve preservar caracteres não consecutivos duplicados")]
        public void RemoveConsecutiveDuplicates_NonConsecutiveDuplicates_PreservesThem()
        {
            // Arrange
            var input = "ABABAB";

            // Act
            var result = _service.RemoveConsecutiveDuplicates(input);

            // Assert
            result.Should().Be("ABABAB");
        }

        [Fact(DisplayName = "Deve processar strings longas com múltiplas duplicações")]
        public void RemoveConsecutiveDuplicates_LongStringWithMultipleDuplicates_ProcessesCorrectly()
        {
            // Arrange
            var input = "AAAABBBBCCCCDDDDEEEE";

            // Act
            var result = _service.RemoveConsecutiveDuplicates(input);

            // Assert
            result.Should().Be("ABCDE");
        }

        [Theory(DisplayName = "Deve processar diversos cenários de teste corretamente")]
        [InlineData("AAA", "A")]
        [InlineData("AABBCC", "ABC")]
        [InlineData("123", "123")]
        [InlineData("1112223", "123")]
        [InlineData("aAbBcC", "aAbBcC")]
        [InlineData("aaaBBBccc", "aBc")]
        public void RemoveConsecutiveDuplicates_VariousScenarios_ProcessesCorrectly(string input, string expected)
        {
            // Act
            var result = _service.RemoveConsecutiveDuplicates(input);

            // Assert
            result.Should().Be(expected);
        }

        [Fact(DisplayName = "Deve processar string com case-sensitive corretamente")]
        public void RemoveConsecutiveDuplicates_CaseSensitive_TreatsDifferentCasesAsDifferent()
        {
            // Arrange
            var input = "AAAaaa";

            // Act
            var result = _service.RemoveConsecutiveDuplicates(input);

            // Assert
            result.Should().Be("Aa");
        }
    }
}

