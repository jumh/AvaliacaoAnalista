# Teste1.Tests - Testes Automatizados

## Cobertura de Testes

Este projeto contém testes automatizados completos para garantir a qualidade e confiabilidade da aplicação Teste1.

### Resultados dos Testes

```
Total de testes: 46
Aprovados: 46
Falhados: 0
Tempo de execução: ~0.5 segundos
```

## Estrutura dos Testes

### Services/StringDeduplicationServiceTests.cs (16 testes)

Testa o serviço principal de remoção de duplicados consecutivos:

- Remoção correta de caracteres duplicados
- Tratamento de strings vazias e nulas
- Strings com um único caractere
- Strings sem duplicados
- Strings alfanuméricas mistas
- Strings apenas numéricas
- Preservação de caracteres não consecutivos
- Strings longas com múltiplas duplicações
- Case-sensitive (maiúsculas vs minúsculas)
- Múltiplos cenários via Theory

### Services/InputValidationServiceTests.cs (24 testes)

Testa todas as validações de entrada:

- Strings alfanuméricas válidas
- Strings vazias e nulas
- Strings com apenas espaços
- Strings com caracteres especiais
- Strings com espaços no meio
- Apenas letras (diversos casos)
- Apenas números
- Símbolos diversos (@, #, $, %, &, *, !)
- Strings mistas
- Strings longas

### Controllers/StringProcessControllerTests.cs (6 testes)

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
# Apenas testes do StringDeduplicationService
dotnet test --filter "FullyQualifiedName~StringDeduplicationServiceTests"

# Apenas testes do InputValidationService
dotnet test --filter "FullyQualifiedName~InputValidationServiceTests"

# Apenas testes do Controller
dotnet test --filter "FullyQualifiedName~StringProcessControllerTests"
```

### Executar testes com cobertura de código

```bash
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=opencover
```

## Estatísticas de Testes

| Componente | Testes | Status |
|-----------|--------|--------|
| StringDeduplicationService | 16 | 100% |
| InputValidationService | 24 | 100% |
| StringProcessController | 6 | 100% |
| **TOTAL** | **46** | **100%** |

## Cenários de Teste Cobertos

### Cenários Positivos
- Entrada válida com duplicados
- Entrada alfanumérica mista
- Strings com letras e números
- Processamento em lote

### Cenários Negativos
- Entrada vazia/nula
- Caracteres especiais
- Espaços em branco
- Validação de dependências

### Casos Extremos (Edge Cases)
- String de um caractere
- String muito longa
- Todos os caracteres iguais
- Nenhum duplicado
- Case sensitivity

## Boas Práticas Implementadas

### Padrão AAA (Arrange-Act-Assert)
Todos os testes seguem o padrão AAA:
```csharp
// Arrange - Prepara os dados
var input = "AAABCCDDD";

// Act - Executa a ação
var result = _service.RemoveConsecutiveDuplicates(input);

// Assert - Verifica o resultado
result.Should().Be("ABCD");
```

### DisplayName Descritivo
```csharp
[Fact(DisplayName = "Deve remover caracteres duplicados consecutivos corretamente")]
```

### Theory para Testes Paramétricos
```csharp
[Theory(DisplayName = "Deve processar diversos cenários de teste corretamente")]
[InlineData("AAA", "A")]
[InlineData("AABBCC", "ABC")]
public void RemoveConsecutiveDuplicates_VariousScenarios_ProcessesCorrectly(...)
```

### Mocking com Moq
```csharp
private readonly Mock<IConsoleView> _viewMock;
_viewMock.Setup(v => v.RequestInput()).Returns("ABC");
_viewMock.Verify(v => v.ShowResult(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
```

### FluentAssertions para Legibilidade
```csharp
result.Should().Be("ABCD");
isValid.Should().BeTrue();
errorMessage.Should().BeNull();
act.Should().Throw<ArgumentNullException>().WithParameterName("view");
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

## Manutenção

Para adicionar novos testes:

1. Crie um novo arquivo de teste em `Services/`, `Controllers/` ou `Views/`
2. Siga o padrão de nomenclatura: `[ClassName]Tests.cs`
3. Use o padrão AAA (Arrange-Act-Assert)
4. Adicione DisplayName descritivo
5. Execute os testes para garantir que passam
6. Atualize esta documentação se necessário
