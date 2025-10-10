# Teste 2 - Gerador de Sequência de Fibonacci

## Descrição

Aplicação console em .NET 8 que gera sequências de Fibonacci conforme a quantidade de termos solicitada pelo usuário.

**Exemplo:** Entrada `6` → Resultado: `1, 1, 2, 3, 5, 8`

## Arquitetura

A aplicação foi desenvolvida seguindo o padrão **MVC (Model-View-Controller)** adaptado para console, com ênfase em:

- Separação de responsabilidades
- Injeção de dependências
- Código limpo e testável
- Princípios SOLID

### Estrutura de Pastas

```
Teste2/
├── Controllers/
│   └── FibonacciController.cs        # Orquestra o fluxo da aplicação
├── Models/
│   └── FibonacciInput.cs             # Modelo de dados
├── Services/
│   ├── IFibonacciService.cs
│   ├── FibonacciService.cs           # Lógica de geração de Fibonacci
│   ├── IInputValidationService.cs
│   └── InputValidationService.cs     # Validação de entrada
├── Views/
│   ├── IConsoleView.cs
│   └── ConsoleView.cs                # Interface com usuário
├── Program.cs                         # Ponto de entrada
└── README.md                          # Este arquivo
```

## Como Executar

### Pré-requisitos

- .NET 8 SDK instalado
- Terminal/Console

### Instalando o .NET 8 SDK (Ubuntu/Debian)

Se você ainda não tem o .NET 8 SDK instalado, siga os passos abaixo:

```bash
# 1. Adicione o repositório da Microsoft
wget https://packages.microsoft.com/config/ubuntu/$(lsb_release -rs)/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
rm packages-microsoft-prod.deb

# 2. Atualize os pacotes
sudo apt-get update

# 3. Instale o .NET 8 SDK
sudo apt-get install -y dotnet-sdk-8.0

# 4. Verifique a instalação
dotnet --version
```

**Alternativa rápida usando snap (RECOMENDADO para Ubuntu 24.10):**
```bash
sudo snap install dotnet-sdk --classic --channel=8.0

# Se o comando 'dotnet' não funcionar, crie um alias:
echo 'alias dotnet="snap run dotnet-sdk.dotnet"' >> ~/.zshrc
source ~/.zshrc

# Ou use diretamente:
snap run dotnet-sdk.dotnet --version
```

**Para outras distribuições Linux:**
- Fedora/RHEL: https://learn.microsoft.com/pt-br/dotnet/core/install/linux-rhel
- Arch Linux: `sudo pacman -S dotnet-sdk`
- Consulte: https://dotnet.microsoft.com/download/dotnet/8.0

### Opção 1: Via .NET CLI

```bash
# Navegue até a pasta do projeto
cd Teste2

# Execute a aplicação
dotnet run
```

### Opção 2: Build e Execução

```bash
# Build do projeto
dotnet build

# Execução do executável
dotnet bin/Debug/net8.0/Teste2.dll
```

### Opção 3: Publicação

```bash
# Publica a aplicação
dotnet publish -c Release -o ./publish

# Executa o publicado
./publish/Teste2
```

## Como Usar

1. Execute a aplicação
2. Digite um número inteiro entre 1 e 19
3. Veja a sequência de Fibonacci gerada
4. Escolha se deseja gerar outra sequência ou sair

### Exemplo de Uso

```
╔═══════════════════════════════════════════════════════════╗
║          Gerador de Sequência de Fibonacci               ║
╚═══════════════════════════════════════════════════════════╝

Esta aplicação gera sequências de Fibonacci.
Digite um número entre 1 e 19 para gerar a sequência.
Exemplo: 6 -> 1, 1, 2, 3, 5, 8

Digite a quantidade de termos (1-19): 8

Sequência gerada com sucesso!

Quantidade de termos: 8
Sequência de Fibonacci: 1, 1, 2, 3, 5, 8, 13, 21

Deseja gerar outra sequência? (S/N): N

Obrigado por usar o sistema! Até logo!
```

## Validações

A aplicação valida:

- Entrada não pode ser vazia
- Deve ser um número inteiro válido
- Número deve ser maior que 0
- Número deve ser menor que 20 (entre 1 e 19)

## Tecnologias Utilizadas

- **.NET 8.0**
- **C# 12**
- **Padrão MVC**
- **Injeção de Dependências**
- **Interfaces para abstração**

## Princípios Aplicados

### SOLID

- **S** - Single Responsibility: Cada classe tem uma única responsabilidade
- **O** - Open/Closed: Aberto para extensão, fechado para modificação
- **L** - Liskov Substitution: Uso de interfaces e contratos
- **I** - Interface Segregation: Interfaces específicas e coesas
- **D** - Dependency Inversion: Dependência de abstrações, não implementações

### Clean Code

- Nomes descritivos e significativos
- Métodos pequenos e focados
- Comentários XML para documentação
- Tratamento de exceções adequado
- Validação de parâmetros

## Complexidade

**Algoritmo de Fibonacci:**
- **Tempo:** O(n) - onde n é a quantidade de termos
- **Espaço:** O(n) - Lista para armazenar a sequência

**Implementação:**
- Iterativa (não recursiva) para melhor performance
- Uso de `long` para suportar números grandes
- Sem risco de stack overflow

## Estrutura do Código

### Services (Lógica de Negócio)

**FibonacciService:** Gera sequências de Fibonacci
- Implementação iterativa eficiente
- Usa tipo `long` para suportar números maiores
- Retorna lista ordenada com a sequência

**InputValidationService:** Valida entradas do usuário
- Verifica se não está vazia
- Garante que é número inteiro
- Valida intervalo (1-19)

### Controllers (Orquestração)

**FibonacciController:** Coordena o fluxo
- Gerencia o loop principal
- Orquestra chamadas entre View e Services
- Trata exceções

### Views (Interface)

**ConsoleView:** Interação com usuário
- Formatação visual com cores
- Mensagens claras e informativas
- Feedback visual

### Models (Dados)

**FibonacciInput:** Encapsula dados da operação
- Quantidade de termos
- Sequência gerada
- Status de validação

## Sobre a Sequência de Fibonacci

A sequência de Fibonacci é uma série de números onde cada número é a soma dos dois números anteriores:

```
F(1) = 1
F(2) = 1
F(n) = F(n-1) + F(n-2) para n > 2
```

Sequência completa até 19 termos:
```
1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181
```

## Autor

Desenvolvido como parte do desafio técnico Supero.

## Testes Automatizados

O projeto possui **49 testes automatizados** com **100% de cobertura** dos componentes críticos.

### Executar os Testes

```bash
# Navegar até o diretório de testes
cd Tests

# Executar todos os testes
dotnet test

# Executar com detalhes
dotnet test --verbosity normal
```

### Cobertura de Testes

| Componente | Testes | Status |
|-----------|--------|--------|
| FibonacciService | 16 | 100% |
| InputValidationService | 27 | 100% |
| FibonacciController | 6 | 100% |
| **TOTAL** | **49** | **100%** |

### Frameworks de Teste Utilizados

#### xUnit (v2.5.3)
Framework de testes unitários para .NET, sucessor do NUnit. Foi escolhido por:
- **Simplicidade**: Sintaxe clara e direta para escrever testes
- **Extensibilidade**: Fácil criação de testes parametrizados com `[Theory]` e `[InlineData]`
- **Isolamento**: Cada teste é executado em uma nova instância da classe
- **Integração**: Suporte nativo no .NET CLI e Visual Studio
- **Paralelização**: Executa testes em paralelo por padrão, aumentando a velocidade

Exemplo de uso:
```csharp
[Fact(DisplayName = "Deve gerar sequência correta")]
public void GenerateSequence_ValidInput_ReturnsCorrectSequence()
{
    // Teste aqui
}

[Theory]
[InlineData(1, new long[] { 1 })]
[InlineData(6, new long[] { 1, 1, 2, 3, 5, 8 })]
public void GenerateSequence_MultipleScenarios(int count, long[] expected)
{
    // Teste parametrizado
}
```

#### FluentAssertions (v8.7.1)
Biblioteca que fornece um conjunto de métodos de extensão para escrever asserções mais legíveis e expressivas:
- **Legibilidade**: Sintaxe fluente que lê como linguagem natural
- **Mensagens de erro detalhadas**: Fornece informações claras quando um teste falha
- **IntelliSense**: Autocomplete ajuda a descobrir asserções disponíveis
- **Extensível**: Permite criar asserções customizadas

Exemplo de uso:
```csharp
// Ao invés de: Assert.Equal(6, result.Count);
result.Should().HaveCount(6);

// Ao invés de: Assert.True(isValid);
isValid.Should().BeTrue();

// Asserções de coleções
result.Should().Equal(1, 1, 2, 3, 5, 8);
```

#### Moq (v4.20.72)
Framework de mocking para criar objetos simulados em testes unitários:
- **Isolamento**: Testa componentes isoladamente sem dependências reais
- **Flexibilidade**: Configura comportamentos específicos para cada teste
- **Verificação**: Confirma se métodos foram chamados conforme esperado
- **Sintaxe intuitiva**: API fluente e fácil de usar

Exemplo de uso:
```csharp
// Criar mock
var mockView = new Mock<IConsoleView>();

// Configurar comportamento
mockView.Setup(v => v.RequestInput()).Returns("6");

// Usar no teste
var controller = new FibonacciController(mockView.Object, ...);

// Verificar chamadas
mockView.Verify(v => v.ShowResult(It.IsAny<int>(), It.IsAny<List<long>>()), 
    Times.Once);
```

### Padrões e Práticas de Teste

- **AAA Pattern (Arrange-Act-Assert)**: Estrutura clara de preparação, ação e verificação
- **Test Naming Convention**: Nomes descritivos no formato `Method_Scenario_ExpectedResult`
- **DisplayName**: Descrições legíveis em português para cada teste
- **Test Isolation**: Cada teste é independente e não afeta outros
- **Theory para testes parametrizados**: Evita duplicação de código
- **Mocking de dependências**: Testes unitários puros e rápidos

Para mais detalhes, consulte: [Tests/README.md](Tests/README.md)

## Licença

Este projeto faz parte de um teste técnico.

