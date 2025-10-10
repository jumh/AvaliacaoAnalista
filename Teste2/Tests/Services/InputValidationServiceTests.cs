using FluentAssertions;
using Teste2.Services;

namespace Teste2.Tests.Services
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

        [Fact(DisplayName = "Deve validar número 1 como válido")]
        public void Validate_Number1_ReturnsValid()
        {
            // Arrange
            var input = "1";

            // Act
            var (isValid, number, errorMessage) = _service.Validate(input);

            // Assert
            isValid.Should().BeTrue();
            number.Should().Be(1);
            errorMessage.Should().BeNull();
        }

        [Fact(DisplayName = "Deve validar número 19 como válido")]
        public void Validate_Number19_ReturnsValid()
        {
            // Arrange
            var input = "19";

            // Act
            var (isValid, number, errorMessage) = _service.Validate(input);

            // Assert
            isValid.Should().BeTrue();
            number.Should().Be(19);
            errorMessage.Should().BeNull();
        }

        [Fact(DisplayName = "Deve validar número 10 como válido")]
        public void Validate_Number10_ReturnsValid()
        {
            // Arrange
            var input = "10";

            // Act
            var (isValid, number, errorMessage) = _service.Validate(input);

            // Assert
            isValid.Should().BeTrue();
            number.Should().Be(10);
            errorMessage.Should().BeNull();
        }

        [Fact(DisplayName = "Deve invalidar string vazia")]
        public void Validate_EmptyString_ReturnsInvalid()
        {
            // Arrange
            var input = "";

            // Act
            var (isValid, number, errorMessage) = _service.Validate(input);

            // Assert
            isValid.Should().BeFalse();
            number.Should().Be(0);
            errorMessage.Should().Be("A entrada não pode ser vazia.");
        }

        [Fact(DisplayName = "Deve invalidar string null")]
        public void Validate_NullString_ReturnsInvalid()
        {
            // Arrange
            string? input = null;

            // Act
            var (isValid, number, errorMessage) = _service.Validate(input!);

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
            var (isValid, number, errorMessage) = _service.Validate(input);

            // Assert
            isValid.Should().BeFalse();
            errorMessage.Should().Be("A entrada não pode ser vazia.");
        }

        [Fact(DisplayName = "Deve invalidar texto que não é número")]
        public void Validate_NonNumericString_ReturnsInvalid()
        {
            // Arrange
            var input = "abc";

            // Act
            var (isValid, number, errorMessage) = _service.Validate(input);

            // Assert
            isValid.Should().BeFalse();
            errorMessage.Should().Be("A entrada deve ser um número inteiro válido.");
        }

        [Fact(DisplayName = "Deve invalidar número decimal")]
        public void Validate_DecimalNumber_ReturnsInvalid()
        {
            // Arrange
            var input = "10.5";

            // Act
            var (isValid, number, errorMessage) = _service.Validate(input);

            // Assert
            isValid.Should().BeFalse();
            errorMessage.Should().Be("A entrada deve ser um número inteiro válido.");
        }

        [Fact(DisplayName = "Deve invalidar número 0")]
        public void Validate_Zero_ReturnsInvalid()
        {
            // Arrange
            var input = "0";

            // Act
            var (isValid, number, errorMessage) = _service.Validate(input);

            // Assert
            isValid.Should().BeFalse();
            errorMessage.Should().Be("O número deve ser maior que 0.");
        }

        [Fact(DisplayName = "Deve invalidar número negativo")]
        public void Validate_NegativeNumber_ReturnsInvalid()
        {
            // Arrange
            var input = "-5";

            // Act
            var (isValid, number, errorMessage) = _service.Validate(input);

            // Assert
            isValid.Should().BeFalse();
            errorMessage.Should().Be("O número deve ser maior que 0.");
        }

        [Fact(DisplayName = "Deve invalidar número 20")]
        public void Validate_Number20_ReturnsInvalid()
        {
            // Arrange
            var input = "20";

            // Act
            var (isValid, number, errorMessage) = _service.Validate(input);

            // Assert
            isValid.Should().BeFalse();
            errorMessage.Should().Be("O número deve ser menor que 20.");
        }

        [Fact(DisplayName = "Deve invalidar número maior que 20")]
        public void Validate_NumberGreaterThan20_ReturnsInvalid()
        {
            // Arrange
            var input = "25";

            // Act
            var (isValid, number, errorMessage) = _service.Validate(input);

            // Assert
            isValid.Should().BeFalse();
            errorMessage.Should().Be("O número deve ser menor que 20.");
        }

        [Fact(DisplayName = "Deve invalidar número muito grande")]
        public void Validate_VeryLargeNumber_ReturnsInvalid()
        {
            // Arrange
            var input = "1000";

            // Act
            var (isValid, number, errorMessage) = _service.Validate(input);

            // Assert
            isValid.Should().BeFalse();
            errorMessage.Should().Be("O número deve ser menor que 20.");
        }

        [Theory(DisplayName = "Deve validar todos os números válidos de 1 a 19")]
        [InlineData("1")]
        [InlineData("5")]
        [InlineData("10")]
        [InlineData("15")]
        [InlineData("19")]
        public void Validate_ValidNumbers_ReturnsValid(string input)
        {
            // Act
            var (isValid, number, errorMessage) = _service.Validate(input);

            // Assert
            isValid.Should().BeTrue();
            number.Should().BeInRange(1, 19);
            errorMessage.Should().BeNull();
        }

        [Theory(DisplayName = "Deve invalidar números fora do intervalo")]
        [InlineData("0", "O número deve ser maior que 0.")]
        [InlineData("-1", "O número deve ser maior que 0.")]
        [InlineData("20", "O número deve ser menor que 20.")]
        [InlineData("100", "O número deve ser menor que 20.")]
        public void Validate_NumbersOutOfRange_ReturnsInvalid(string input, string expectedError)
        {
            // Act
            var (isValid, number, errorMessage) = _service.Validate(input);

            // Assert
            isValid.Should().BeFalse();
            errorMessage.Should().Be(expectedError);
        }

        [Fact(DisplayName = "Deve invalidar entrada com caracteres especiais")]
        public void Validate_SpecialCharacters_ReturnsInvalid()
        {
            // Arrange
            var input = "10@";

            // Act
            var (isValid, number, errorMessage) = _service.Validate(input);

            // Assert
            isValid.Should().BeFalse();
            errorMessage.Should().Be("A entrada deve ser um número inteiro válido.");
        }

        [Fact(DisplayName = "Deve invalidar entrada alfanumérica")]
        public void Validate_AlphanumericString_ReturnsInvalid()
        {
            // Arrange
            var input = "10a";

            // Act
            var (isValid, number, errorMessage) = _service.Validate(input);

            // Assert
            isValid.Should().BeFalse();
            errorMessage.Should().Be("A entrada deve ser um número inteiro válido.");
        }

        [Fact(DisplayName = "Deve retornar número convertido quando válido")]
        public void Validate_ValidInput_ReturnsConvertedNumber()
        {
            // Arrange
            var input = "15";

            // Act
            var (isValid, number, errorMessage) = _service.Validate(input);

            // Assert
            isValid.Should().BeTrue();
            number.Should().Be(15);
        }
    }
}

