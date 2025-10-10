using FluentAssertions;
using Moq;
using Teste2.Controllers;
using Teste2.Services;
using Teste2.Views;

namespace Teste2.Tests.Controllers
{
    /// <summary>
    /// Testes para o controller de geração de Fibonacci.
    /// </summary>
    public class FibonacciControllerTests
    {
        private readonly Mock<IConsoleView> _viewMock;
        private readonly Mock<IInputValidationService> _validationServiceMock;
        private readonly Mock<IFibonacciService> _fibonacciServiceMock;
        private readonly FibonacciController _controller;

        public FibonacciControllerTests()
        {
            _viewMock = new Mock<IConsoleView>();
            _validationServiceMock = new Mock<IInputValidationService>();
            _fibonacciServiceMock = new Mock<IFibonacciService>();

            _controller = new FibonacciController(
                _viewMock.Object,
                _validationServiceMock.Object,
                _fibonacciServiceMock.Object
            );
        }

        [Fact(DisplayName = "Deve lançar ArgumentNullException quando view é null")]
        public void Constructor_NullView_ThrowsArgumentNullException()
        {
            // Act & Assert
            Action act = () => new FibonacciController(
                null!,
                _validationServiceMock.Object,
                _fibonacciServiceMock.Object
            );

            act.Should().Throw<ArgumentNullException>()
                .WithParameterName("view");
        }

        [Fact(DisplayName = "Deve lançar ArgumentNullException quando validationService é null")]
        public void Constructor_NullValidationService_ThrowsArgumentNullException()
        {
            // Act & Assert
            Action act = () => new FibonacciController(
                _viewMock.Object,
                null!,
                _fibonacciServiceMock.Object
            );

            act.Should().Throw<ArgumentNullException>()
                .WithParameterName("validationService");
        }

        [Fact(DisplayName = "Deve lançar ArgumentNullException quando fibonacciService é null")]
        public void Constructor_NullFibonacciService_ThrowsArgumentNullException()
        {
            // Act & Assert
            Action act = () => new FibonacciController(
                _viewMock.Object,
                _validationServiceMock.Object,
                null!
            );

            act.Should().Throw<ArgumentNullException>()
                .WithParameterName("fibonacciService");
        }

        [Fact(DisplayName = "Run deve exibir mensagem de boas-vindas")]
        public void Run_Always_ShowsWelcomeMessage()
        {
            // Arrange
            _viewMock.Setup(v => v.RequestInput()).Returns("5");
            _viewMock.Setup(v => v.AskToContinue()).Returns(false);
            _validationServiceMock.Setup(v => v.Validate(It.IsAny<string>()))
                .Returns((true, 5, null));
            _fibonacciServiceMock.Setup(f => f.GenerateSequence(It.IsAny<int>()))
                .Returns(new List<long> { 1, 1, 2, 3, 5 });

            // Act
            _controller.Run();

            // Assert
            _viewMock.Verify(v => v.ShowWelcomeMessage(), Times.Once);
        }

        [Fact(DisplayName = "Run deve exibir mensagem de despedida ao final")]
        public void Run_Always_ShowsGoodbyeMessage()
        {
            // Arrange
            _viewMock.Setup(v => v.RequestInput()).Returns("5");
            _viewMock.Setup(v => v.AskToContinue()).Returns(false);
            _validationServiceMock.Setup(v => v.Validate(It.IsAny<string>()))
                .Returns((true, 5, null));
            _fibonacciServiceMock.Setup(f => f.GenerateSequence(It.IsAny<int>()))
                .Returns(new List<long> { 1, 1, 2, 3, 5 });

            // Act
            _controller.Run();

            // Assert
            _viewMock.Verify(v => v.ShowGoodbyeMessage(), Times.Once);
        }

        [Fact(DisplayName = "Run deve processar entrada válida e exibir resultado")]
        public void Run_ValidInput_ProcessesAndShowsResult()
        {
            // Arrange
            var input = "6";
            var count = 6;
            var sequence = new List<long> { 1, 1, 2, 3, 5, 8 };

            _viewMock.Setup(v => v.RequestInput()).Returns(input);
            _viewMock.Setup(v => v.AskToContinue()).Returns(false);
            _validationServiceMock.Setup(v => v.Validate(input))
                .Returns((true, count, null));
            _fibonacciServiceMock.Setup(f => f.GenerateSequence(count))
                .Returns(sequence);

            // Act
            _controller.Run();

            // Assert
            _viewMock.Verify(v => v.ShowResult(count, sequence), Times.Once);
            _fibonacciServiceMock.Verify(f => f.GenerateSequence(count), Times.Once);
        }

        [Fact(DisplayName = "Run deve exibir erro quando validação falha")]
        public void Run_InvalidInput_ShowsError()
        {
            // Arrange
            var input = "25";
            var errorMessage = "Número inválido";

            _viewMock.Setup(v => v.RequestInput()).Returns(input);
            _viewMock.Setup(v => v.AskToContinue()).Returns(false);
            _validationServiceMock.Setup(v => v.Validate(input))
                .Returns((false, 0, errorMessage));

            // Act
            _controller.Run();

            // Assert
            _viewMock.Verify(v => v.ShowError(errorMessage), Times.Once);
            _fibonacciServiceMock.Verify(
                f => f.GenerateSequence(It.IsAny<int>()),
                Times.Never
            );
        }

        [Fact(DisplayName = "Run deve processar múltiplas entradas quando usuário continua")]
        public void Run_UserContinues_ProcessesMultipleInputs()
        {
            // Arrange
            var inputs = new Queue<string>(new[] { "5", "10" });
            var continueResponses = new Queue<bool>(new[] { true, false });

            _viewMock.Setup(v => v.RequestInput()).Returns(inputs.Dequeue);
            _viewMock.Setup(v => v.AskToContinue()).Returns(continueResponses.Dequeue);
            _validationServiceMock.Setup(v => v.Validate(It.IsAny<string>()))
                .Returns<string>(s => (true, int.Parse(s), null));
            _fibonacciServiceMock.Setup(f => f.GenerateSequence(It.IsAny<int>()))
                .Returns(new List<long> { 1, 1, 2 });

            // Act
            _controller.Run();

            // Assert
            _viewMock.Verify(v => v.ShowResult(It.IsAny<int>(), It.IsAny<List<long>>()), Times.Exactly(2));
        }

        [Fact(DisplayName = "Run deve exibir erro quando entrada é null")]
        public void Run_NullInput_ShowsError()
        {
            // Arrange
            _viewMock.Setup(v => v.RequestInput()).Returns((string?)null);
            _viewMock.Setup(v => v.AskToContinue()).Returns(false);

            // Act
            _controller.Run();

            // Assert
            _viewMock.Verify(v => v.ShowError("Entrada inválida."), Times.Once);
        }
    }
}

