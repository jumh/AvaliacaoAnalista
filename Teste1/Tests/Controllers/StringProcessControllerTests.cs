using FluentAssertions;
using Moq;
using Teste1.Controllers;
using Teste1.Services;
using Teste1.Views;

namespace Teste1.Tests.Controllers
{
    /// <summary>
    /// Testes para o controller de processamento de strings.
    /// </summary>
    public class StringProcessControllerTests
    {
        private readonly Mock<IConsoleView> _viewMock;
        private readonly Mock<IInputValidationService> _validationServiceMock;
        private readonly Mock<IStringDeduplicationService> _deduplicationServiceMock;
        private readonly StringProcessController _controller;

        public StringProcessControllerTests()
        {
            _viewMock = new Mock<IConsoleView>();
            _validationServiceMock = new Mock<IInputValidationService>();
            _deduplicationServiceMock = new Mock<IStringDeduplicationService>();

            _controller = new StringProcessController(
                _viewMock.Object,
                _validationServiceMock.Object,
                _deduplicationServiceMock.Object
            );
        }

        [Fact(DisplayName = "Deve lançar ArgumentNullException quando view é null")]
        public void Constructor_NullView_ThrowsArgumentNullException()
        {
            // Act & Assert
            Action act = () => new StringProcessController(
                null!,
                _validationServiceMock.Object,
                _deduplicationServiceMock.Object
            );

            act.Should().Throw<ArgumentNullException>()
                .WithParameterName("view");
        }

        [Fact(DisplayName = "Deve lançar ArgumentNullException quando validationService é null")]
        public void Constructor_NullValidationService_ThrowsArgumentNullException()
        {
            // Act & Assert
            Action act = () => new StringProcessController(
                _viewMock.Object,
                null!,
                _deduplicationServiceMock.Object
            );

            act.Should().Throw<ArgumentNullException>()
                .WithParameterName("validationService");
        }

        [Fact(DisplayName = "Deve lançar ArgumentNullException quando deduplicationService é null")]
        public void Constructor_NullDeduplicationService_ThrowsArgumentNullException()
        {
            // Act & Assert
            Action act = () => new StringProcessController(
                _viewMock.Object,
                _validationServiceMock.Object,
                null!
            );

            act.Should().Throw<ArgumentNullException>()
                .WithParameterName("deduplicationService");
        }

        [Fact(DisplayName = "Run deve exibir mensagem de boas-vindas")]
        public void Run_Always_ShowsWelcomeMessage()
        {
            // Arrange
            _viewMock.Setup(v => v.RequestInput()).Returns("ABC");
            _viewMock.Setup(v => v.AskToContinue()).Returns(false);
            _validationServiceMock.Setup(v => v.Validate(It.IsAny<string>()))
                .Returns((true, null));
            _deduplicationServiceMock.Setup(d => d.RemoveConsecutiveDuplicates(It.IsAny<string>()))
                .Returns("ABC");

            // Act
            _controller.Run();

            // Assert
            _viewMock.Verify(v => v.ShowWelcomeMessage(), Times.Once);
        }

        [Fact(DisplayName = "Run deve exibir mensagem de despedida ao final")]
        public void Run_Always_ShowsGoodbyeMessage()
        {
            // Arrange
            _viewMock.Setup(v => v.RequestInput()).Returns("ABC");
            _viewMock.Setup(v => v.AskToContinue()).Returns(false);
            _validationServiceMock.Setup(v => v.Validate(It.IsAny<string>()))
                .Returns((true, null));
            _deduplicationServiceMock.Setup(d => d.RemoveConsecutiveDuplicates(It.IsAny<string>()))
                .Returns("ABC");

            // Act
            _controller.Run();

            // Assert
            _viewMock.Verify(v => v.ShowGoodbyeMessage(), Times.Once);
        }

        [Fact(DisplayName = "Run deve processar entrada válida e exibir resultado")]
        public void Run_ValidInput_ProcessesAndShowsResult()
        {
            // Arrange
            var input = "AAABCCDDD";
            var processed = "ABCD";

            _viewMock.Setup(v => v.RequestInput()).Returns(input);
            _viewMock.Setup(v => v.AskToContinue()).Returns(false);
            _validationServiceMock.Setup(v => v.Validate(input))
                .Returns((true, null));
            _deduplicationServiceMock.Setup(d => d.RemoveConsecutiveDuplicates(input))
                .Returns(processed);

            // Act
            _controller.Run();

            // Assert
            _viewMock.Verify(v => v.ShowResult(input, processed), Times.Once);
            _deduplicationServiceMock.Verify(d => d.RemoveConsecutiveDuplicates(input), Times.Once);
        }

        [Fact(DisplayName = "Run deve exibir erro quando validação falha")]
        public void Run_InvalidInput_ShowsError()
        {
            // Arrange
            var input = "ABC@123";
            var errorMessage = "Entrada inválida";

            _viewMock.Setup(v => v.RequestInput()).Returns(input);
            _viewMock.Setup(v => v.AskToContinue()).Returns(false);
            _validationServiceMock.Setup(v => v.Validate(input))
                .Returns((false, errorMessage));

            // Act
            _controller.Run();

            // Assert
            _viewMock.Verify(v => v.ShowError(errorMessage), Times.Once);
            _deduplicationServiceMock.Verify(
                d => d.RemoveConsecutiveDuplicates(It.IsAny<string>()),
                Times.Never
            );
        }

        [Fact(DisplayName = "Run deve processar múltiplas entradas quando usuário continua")]
        public void Run_UserContinues_ProcessesMultipleInputs()
        {
            // Arrange
            var inputs = new Queue<string>(new[] { "AAA", "BBB" });
            var continueResponses = new Queue<bool>(new[] { true, false });

            _viewMock.Setup(v => v.RequestInput()).Returns(inputs.Dequeue);
            _viewMock.Setup(v => v.AskToContinue()).Returns(continueResponses.Dequeue);
            _validationServiceMock.Setup(v => v.Validate(It.IsAny<string>()))
                .Returns((true, null));
            _deduplicationServiceMock.Setup(d => d.RemoveConsecutiveDuplicates(It.IsAny<string>()))
                .Returns<string>(s => s.Substring(0, 1));

            // Act
            _controller.Run();

            // Assert
            _viewMock.Verify(v => v.ShowResult(It.IsAny<string>(), It.IsAny<string>()), Times.Exactly(2));
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

