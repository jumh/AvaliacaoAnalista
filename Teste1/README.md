# Teste 1 - Removedor de Caracteres Duplicados Consecutivos

## Descrição

Aplicação console em .NET 8 que remove caracteres duplicados consecutivos de uma string alfanumérica.

**Exemplo:** `AAABCCDDD` → `ABCD`

## Arquitetura

A aplicação foi desenvolvida seguindo o padrão **MVC (Model-View-Controller)** adaptado para console, com ênfase em:

- Separação de responsabilidades
- Injeção de dependências
- Código limpo e testável
- Princípios SOLID

### Estrutura de Pastas

```
Teste1/
├── Controllers/
│   └── StringProcessController.cs    # Orquestra o fluxo da aplicação
├── Models/
│   └── StringInput.cs                # Modelo de dados
├── Services/
│   ├── IStringDeduplicationService.cs
│   ├── StringDeduplicationService.cs # Lógica de remoção de duplicados
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
cd Teste1

# Execute a aplicação
dotnet run
```

### Opção 2: Build e Execução

```bash
# Build do projeto
dotnet build

# Execução do executável
dotnet bin/Debug/net8.0/Teste1.dll
```

### Opção 3: Publicação

```bash
# Publica a aplicação
dotnet publish -c Release -o ./publish

# Executa o publicado
./publish/Teste1
```

## Como Usar

1. Execute a aplicação
2. Digite uma string alfanumérica quando solicitado
3. Veja o resultado processado
4. Escolha se deseja processar outra string ou sair

### Exemplo de Uso

```
╔═══════════════════════════════════════════════════════════╗
║     Removedor de Caracteres Duplicados Consecutivos      ║
╚═══════════════════════════════════════════════════════════╝

Esta aplicação remove caracteres duplicados consecutivos.
Exemplo: AAABCCDDD -> ABCD

Digite uma string alfanumérica: AAABCCDDD

Processamento concluído com sucesso!

String Original:    AAABCCDDD
String Processada:  ABCD

Deseja processar outra string? (S/N): N

Obrigado por usar o sistema! Até logo!
```

## Validações

A aplicação valida:

- String não pode ser vazia
- Deve conter apenas caracteres alfanuméricos (letras e números)
- Não são permitidos caracteres especiais ou espaços

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

**Algoritmo de Remoção de Duplicados:**
- **Tempo:** O(n) - onde n é o tamanho da string
- **Espaço:** O(n) - StringBuilder para construção do resultado

## Estrutura do Código

### Services (Lógica de Negócio)

**StringDeduplicationService:** Remove caracteres duplicados consecutivos
- Utiliza StringBuilder para eficiência
- Compara cada caractere com o anterior
- Retorna string limpa

**InputValidationService:** Valida entradas do usuário
- Verifica se não está vazia
- Garante que é alfanumérica

### Controllers (Orquestração)

**StringProcessController:** Coordena o fluxo
- Gerencia o loop principal
- Orquestra chamadas entre View e Services
- Trata exceções

### Views (Interface)

**ConsoleView:** Interação com usuário
- Formatação visual com cores
- Mensagens claras e amigáveis
- Feedback visual

### Models (Dados)

**StringInput:** Encapsula dados da operação
- String original
- String processada
- Status de validação

## Autor

Desenvolvido como parte do desafio técnico Supero.

## Testes Automatizados

O projeto possui **46 testes automatizados** com **100% de cobertura** dos componentes críticos.

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
| StringDeduplicationService | 16 | 100% |
| InputValidationService | 24 | 100% |
| StringProcessController | 6 | 100% |
| **TOTAL** | **46** | **100%** |

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
[Fact(DisplayName = "Deve remover caracteres duplicados")]
public void RemoveConsecutiveDuplicates_ValidInput_RemovesDuplicates()
{
    // Teste aqui
}

[Theory]
[InlineData("AAA", "A")]
[InlineData("AABBCC", "ABC")]
public void RemoveConsecutiveDuplicates_MultipleScenarios(string input, string expected)
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
// Ao invés de: Assert.Equal("ABCD", result);
result.Should().Be("ABCD");

// Ao invés de: Assert.True(isValid);
isValid.Should().BeTrue();

// Asserções complexas
errorMessage.Should().NotBeNullOrEmpty()
    .And.Contain("alfanumérico");
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
mockView.Setup(v => v.RequestInput()).Returns("ABC");

// Usar no teste
var controller = new StringProcessController(mockView.Object, ...);

// Verificar chamadas
mockView.Verify(v => v.ShowResult(It.IsAny<string>(), It.IsAny<string>()), 
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
