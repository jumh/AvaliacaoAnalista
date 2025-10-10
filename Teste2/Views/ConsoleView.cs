namespace Teste2.Views
{
    /// <summary>
    /// Implementação da camada de visualização para interação via console.
    /// </summary>
    public class ConsoleView : IConsoleView
    {
        public void ShowWelcomeMessage()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔═══════════════════════════════════════════════════════════╗");
            Console.WriteLine("║          Gerador de Sequência de Fibonacci               ║");
            Console.WriteLine("╚═══════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Esta aplicação gera sequências de Fibonacci.");
            Console.WriteLine("Digite um número entre 1 e 19 para gerar a sequência.");
            Console.WriteLine("Exemplo: 6 -> 1, 1, 2, 3, 5, 8");
            Console.WriteLine();
        }

        public string? RequestInput()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Digite a quantidade de termos (1-19): ");
            Console.ResetColor();
            return Console.ReadLine();
        }

        public void ShowError(string errorMessage)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nErro: {errorMessage}");
            Console.ResetColor();
            Console.WriteLine();
        }

        public void ShowResult(int count, List<long> sequence)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Sequência gerada com sucesso!");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine($"Quantidade de termos: {count}");
            Console.WriteLine($"Sequência de Fibonacci: {string.Join(", ", sequence)}");
            Console.WriteLine();
        }

        public bool AskToContinue()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Deseja gerar outra sequência? (S/N): ");
            Console.ResetColor();
            
            var response = Console.ReadLine()?.Trim().ToUpper();
            Console.WriteLine();
            
            return response == "S" || response == "SIM";
        }

        public void ShowGoodbyeMessage()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Obrigado por usar o sistema! Até logo!");
            Console.ResetColor();
        }
    }
}

