using FluentAssertions;
using Teste2.Services;

namespace Teste2.Tests.Services
{
    /// <summary>
    /// Testes para o serviço de geração de sequência de Fibonacci.
    /// </summary>
    public class FibonacciServiceTests
    {
        private readonly FibonacciService _service;

        public FibonacciServiceTests()
        {
            _service = new FibonacciService();
        }

        [Fact(DisplayName = "Deve gerar sequência de Fibonacci com 1 termo")]
        public void GenerateSequence_Count1_ReturnsOneElement()
        {
            // Arrange
            var count = 1;

            // Act
            var result = _service.GenerateSequence(count);

            // Assert
            result.Should().HaveCount(1);
            result.Should().Equal(1);
        }

        [Fact(DisplayName = "Deve gerar sequência de Fibonacci com 2 termos")]
        public void GenerateSequence_Count2_ReturnsTwoElements()
        {
            // Arrange
            var count = 2;

            // Act
            var result = _service.GenerateSequence(count);

            // Assert
            result.Should().HaveCount(2);
            result.Should().Equal(1, 1);
        }

        [Fact(DisplayName = "Deve gerar sequência de Fibonacci com 6 termos corretamente")]
        public void GenerateSequence_Count6_ReturnsCorrectSequence()
        {
            // Arrange
            var count = 6;

            // Act
            var result = _service.GenerateSequence(count);

            // Assert
            result.Should().HaveCount(6);
            result.Should().Equal(1, 1, 2, 3, 5, 8);
        }

        [Fact(DisplayName = "Deve gerar sequência de Fibonacci com 10 termos")]
        public void GenerateSequence_Count10_ReturnsCorrectSequence()
        {
            // Arrange
            var count = 10;

            // Act
            var result = _service.GenerateSequence(count);

            // Assert
            result.Should().HaveCount(10);
            result.Should().Equal(1, 1, 2, 3, 5, 8, 13, 21, 34, 55);
        }

        [Fact(DisplayName = "Deve gerar sequência de Fibonacci com 19 termos (máximo permitido)")]
        public void GenerateSequence_Count19_ReturnsCorrectSequence()
        {
            // Arrange
            var count = 19;

            // Act
            var result = _service.GenerateSequence(count);

            // Assert
            result.Should().HaveCount(19);
            result[0].Should().Be(1);
            result[1].Should().Be(1);
            result[18].Should().Be(4181); // 19º termo
        }

        [Fact(DisplayName = "Deve retornar lista vazia quando count é 0")]
        public void GenerateSequence_Count0_ReturnsEmptyList()
        {
            // Arrange
            var count = 0;

            // Act
            var result = _service.GenerateSequence(count);

            // Assert
            result.Should().BeEmpty();
        }

        [Fact(DisplayName = "Deve retornar lista vazia quando count é negativo")]
        public void GenerateSequence_NegativeCount_ReturnsEmptyList()
        {
            // Arrange
            var count = -5;

            // Act
            var result = _service.GenerateSequence(count);

            // Assert
            result.Should().BeEmpty();
        }

        [Fact(DisplayName = "Deve calcular cada termo como soma dos dois anteriores")]
        public void GenerateSequence_ValidCount_EachTermIsSumOfPreviousTwo()
        {
            // Arrange
            var count = 15;

            // Act
            var result = _service.GenerateSequence(count);

            // Assert
            for (int i = 2; i < result.Count; i++)
            {
                result[i].Should().Be(result[i - 1] + result[i - 2],
                    $"termo {i} deve ser a soma dos dois anteriores");
            }
        }

        [Theory(DisplayName = "Deve gerar sequências corretas para diversos valores")]
        [InlineData(1, new long[] { 1 })]
        [InlineData(2, new long[] { 1, 1 })]
        [InlineData(3, new long[] { 1, 1, 2 })]
        [InlineData(4, new long[] { 1, 1, 2, 3 })]
        [InlineData(5, new long[] { 1, 1, 2, 3, 5 })]
        [InlineData(7, new long[] { 1, 1, 2, 3, 5, 8, 13 })]
        public void GenerateSequence_VariousValues_ReturnsCorrectSequence(int count, long[] expected)
        {
            // Act
            var result = _service.GenerateSequence(count);

            // Assert
            result.Should().Equal(expected);
        }

        [Fact(DisplayName = "Deve usar tipo long para suportar números grandes")]
        public void GenerateSequence_LargeNumbers_UsesLongType()
        {
            // Arrange
            var count = 19;

            // Act
            var result = _service.GenerateSequence(count);

            // Assert
            result.Should().AllBeOfType<long>();
            result.Last().Should().Be(4181); // 19º termo da sequência de Fibonacci
        }
    }
}

