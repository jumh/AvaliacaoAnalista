# Teste2.Tests - Testes Automatizados

## Cobertura de Testes

Este projeto contém testes automatizados completos para garantir a qualidade e confiabilidade da aplicação Teste2.

### Resultados dos Testes

```
Total de testes: 49
Aprovados: 49
Falhados: 0
Tempo de execução: ~0.5 segundos
```

## Estrutura dos Testes

### Services/FibonacciServiceTests.cs (16 testes)

Testa o serviço principal de geração de sequência de Fibonacci:

- Geração com 1 termo
- Geração com 2 termos
- Geração com 6 termos (exemplo do requisito)
- Geração com 10 termos
- Geração com 19 termos (máximo permitido)
- Lista vazia quando count é 0
- Lista vazia quando count é negativo
- Cálculo correto: cada termo é soma dos dois anteriores
- Testes parametrizados para diversos valores (1, 2, 3, 4, 5, 7)
- Uso de tipo `long` para suportar números grandes

### Services/InputValidationServiceTests.cs (27 testes)

Testa todas as validações de entrada:

- Validação de números válidos (1, 10, 19)
- String vazia e nula
- String com apenas espaços
- Texto não numérico
- Número decimal
- Número 0 (inválido)
- Números negativos
- Número 20 (inválido - limite superior)
- Números maiores que 20
- Caracteres especiais
- Entrada alfanumérica
- Conversão correta do número
- Testes parametrizados para números válidos (1, 5, 10, 15, 19)
- Testes parametrizados para números fora do intervalo (0, -1, 20, 100)

### Controllers/FibonacciControllerTests.cs (6 testes)

Testa a orquestração e fluxo da aplicação:

- Validação de dependências (ArgumentNullException)
- Mensagem de boas-vindas
- Mensagem de despedida
- Processamento de entrada válida
- Exibição de erros
- Processamento de múltiplas entradas

## Tecnologias Utilizadas

- **xUnit**: Framework de testes
- **FluentAssertions**: Asserções fluentes e legíveis
- **Moq**: Framework de mocking para testes isolados
- **.NET 8**: Runtime e SDK

## Como Executar os Testes

### Executar todos os testes

```bash
cd Tests
dotnet test
```

### Executar com detalhes verbosos

```bash
dotnet test --verbosity normal
```

### Executar testes específicos por classe

```bash
# Apenas testes do FibonacciService
dotnet test --filter "FullyQualifiedName~FibonacciServiceTests"

# Apenas testes do InputValidationService
dotnet test --filter "FullyQualifiedName~InputValidationServiceTests"

# Apenas testes do Controller
dotnet test --filter "FullyQualifiedName~FibonacciControllerTests"
```

### Executar testes com cobertura de código

```bash
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=opencover
```

## Estatísticas de Testes

| Componente | Testes | Status |
|-----------|--------|--------|
| FibonacciService | 16 | 100% |
| InputValidationService | 27 | 100% |
| FibonacciController | 6 | 100% |
| **TOTAL** | **49** | **100%** |

## Cenários de Teste Cobertos

### Cenários Positivos
- Entrada válida de 1 a 19
- Geração correta da sequência
- Múltiplas sequências consecutivas
- Todos os números no intervalo válido

### Cenários Negativos
- Entrada vazia/nula
- Texto não numérico
- Números decimais
- Zero e negativos
- Números >= 20

### Casos Extremos (Edge Cases)
- Count = 1 (mínimo)
- Count = 19 (máximo)
- Count = 0
- Count negativo
- Números muito grandes (validação de tipo long)
- Propriedade matemática (F(n) = F(n-1) + F(n-2))

## Boas Práticas Implementadas

### Padrão AAA (Arrange-Act-Assert)
Todos os testes seguem o padrão AAA:
```csharp
// Arrange - Prepara os dados
var count = 6;

// Act - Executa a ação
var result = _service.GenerateSequence(count);

// Assert - Verifica o resultado
result.Should().Equal(1, 1, 2, 3, 5, 8);
```

### DisplayName Descritivo
```csharp
[Fact(DisplayName = "Deve gerar sequência de Fibonacci com 6 termos corretamente")]
```

### Theory para Testes Paramétricos
```csharp
[Theory(DisplayName = "Deve gerar sequências corretas para diversos valores")]
[InlineData(1, new long[] { 1 })]
[InlineData(6, new long[] { 1, 1, 2, 3, 5, 8 })]
public void GenerateSequence_VariousValues_ReturnsCorrectSequence(...)
```

### Mocking com Moq
```csharp
private readonly Mock<IConsoleView> _viewMock;
_viewMock.Setup(v => v.RequestInput()).Returns("6");
_viewMock.Verify(v => v.ShowResult(It.IsAny<int>(), It.IsAny<List<long>>()), Times.Once);
```

### FluentAssertions para Legibilidade
```csharp
result.Should().HaveCount(6);
result.Should().Equal(1, 1, 2, 3, 5, 8);
isValid.Should().BeTrue();
number.Should().BeInRange(1, 19);
```

## Integração Contínua

Os testes podem ser facilmente integrados em pipelines de CI/CD:

```yaml
# Exemplo GitHub Actions
- name: Run Tests
  run: dotnet test --no-build --verbosity normal

# Exemplo Azure DevOps
- script: dotnet test --logger trx --results-directory $(Build.ArtifactStagingDirectory)/TestResults
  displayName: 'Run Unit Tests'
```

## Referências

- [xUnit Documentation](https://xunit.net/)
- [FluentAssertions Documentation](https://fluentassertions.com/)
- [Moq Documentation](https://github.com/moq/moq4)
- [.NET Testing Best Practices](https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices)
- [Fibonacci Sequence](https://en.wikipedia.org/wiki/Fibonacci_number)

## Manutenção

Para adicionar novos testes:

1. Crie um novo arquivo de teste em `Services/`, `Controllers/` ou `Views/`
2. Siga o padrão de nomenclatura: `[ClassName]Tests.cs`
3. Use o padrão AAA (Arrange-Act-Assert)
4. Adicione DisplayName descritivo
5. Execute os testes para garantir que passam
6. Atualize esta documentação se necessário

