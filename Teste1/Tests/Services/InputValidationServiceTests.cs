using FluentAssertions;
using Teste1.Services;

namespace Teste1.Tests.Services
{
    /// <summary>
    /// Testes para o serviço de validação de entrada.
    /// </summary>
    public class InputValidationServiceTests
    {
        private readonly InputValidationService _service;

        public InputValidationServiceTests()
        {
            _service = new InputValidationService();
        }

        [Fact(DisplayName = "Deve validar string alfanumérica como válida")]
        public void Validate_AlphanumericString_ReturnsValid()
        {
            // Arrange
            var input = "ABC123";

            // Act
            var (isValid, errorMessage) = _service.Validate(input);

            // Assert
            isValid.Should().BeTrue();
            errorMessage.Should().BeNull();
        }

        [Fact(DisplayName = "Deve invalidar string vazia")]
        public void Validate_EmptyString_ReturnsInvalid()
        {
            // Arrange
            var input = "";

            // Act
            var (isValid, errorMessage) = _service.Validate(input);

            // Assert
            isValid.Should().BeFalse();
            errorMessage.Should().Be("A entrada não pode ser vazia.");
        }

        [Fact(DisplayName = "Deve invalidar string null")]
        public void Validate_NullString_ReturnsInvalid()
        {
            // Arrange
            string? input = null;

            // Act
            var (isValid, errorMessage) = _service.Validate(input!);

            // Assert
            isValid.Should().BeFalse();
            errorMessage.Should().Be("A entrada não pode ser vazia.");
        }

        [Fact(DisplayName = "Deve invalidar string com apenas espaços")]
        public void Validate_WhitespaceString_ReturnsInvalid()
        {
            // Arrange
            var input = "   ";

            // Act
            var (isValid, errorMessage) = _service.Validate(input);

            // Assert
            isValid.Should().BeFalse();
            errorMessage.Should().Be("A entrada não pode ser vazia.");
        }

        [Fact(DisplayName = "Deve invalidar string com caracteres especiais")]
        public void Validate_StringWithSpecialCharacters_ReturnsInvalid()
        {
            // Arrange
            var input = "ABC@123";

            // Act
            var (isValid, errorMessage) = _service.Validate(input);

            // Assert
            isValid.Should().BeFalse();
            errorMessage.Should().Be("A entrada deve conter apenas letras e números (alfanumérico).");
        }

        [Fact(DisplayName = "Deve invalidar string com espaços no meio")]
        public void Validate_StringWithSpaces_ReturnsInvalid()
        {
            // Arrange
            var input = "ABC 123";

            // Act
            var (isValid, errorMessage) = _service.Validate(input);

            // Assert
            isValid.Should().BeFalse();
            errorMessage.Should().Be("A entrada deve conter apenas letras e números (alfanumérico).");
        }

        [Theory(DisplayName = "Deve validar apenas letras como válido")]
        [InlineData("ABC")]
        [InlineData("abc")]
        [InlineData("AbC")]
        public void Validate_OnlyLetters_ReturnsValid(string input)
        {
            // Act
            var (isValid, errorMessage) = _service.Validate(input);

            // Assert
            isValid.Should().BeTrue();
            errorMessage.Should().BeNull();
        }

        [Theory(DisplayName = "Deve validar apenas números como válido")]
        [InlineData("123")]
        [InlineData("456789")]
        [InlineData("0")]
        public void Validate_OnlyNumbers_ReturnsValid(string input)
        {
            // Act
            var (isValid, errorMessage) = _service.Validate(input);

            // Assert
            isValid.Should().BeTrue();
            errorMessage.Should().BeNull();
        }

        [Theory(DisplayName = "Deve invalidar strings com símbolos")]
        [InlineData("ABC!123")]
        [InlineData("Test@123")]
        [InlineData("123#456")]
        [InlineData("ABC$DEF")]
        [InlineData("Test%123")]
        [InlineData("123&456")]
        [InlineData("ABC*DEF")]
        public void Validate_StringsWithSymbols_ReturnsInvalid(string input)
        {
            // Act
            var (isValid, errorMessage) = _service.Validate(input);

            // Assert
            isValid.Should().BeFalse();
            errorMessage.Should().Contain("alfanumérico");
        }

        [Fact(DisplayName = "Deve validar string com números e letras misturados")]
        public void Validate_MixedAlphanumeric_ReturnsValid()
        {
            // Arrange
            var input = "a1B2c3D4";

            // Act
            var (isValid, errorMessage) = _service.Validate(input);

            // Assert
            isValid.Should().BeTrue();
            errorMessage.Should().BeNull();
        }

        [Fact(DisplayName = "Deve validar string longa alfanumérica")]
        public void Validate_LongAlphanumericString_ReturnsValid()
        {
            // Arrange
            var input = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            // Act
            var (isValid, errorMessage) = _service.Validate(input);

            // Assert
            isValid.Should().BeTrue();
            errorMessage.Should().BeNull();
        }
    }
}

