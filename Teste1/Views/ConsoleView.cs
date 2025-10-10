namespace Teste1.Views
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
            Console.WriteLine("║     Removedor de Caracteres Duplicados Consecutivos       ║");
            Console.WriteLine("╚═══════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Esta aplicação remove caracteres duplicados consecutivos.");
            Console.WriteLine("Exemplo: AAABCCDDD -> ABCD");
            Console.WriteLine();
        }

        public string? RequestInput()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Digite uma string alfanumérica: ");
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

        public void ShowResult(string original, string processed)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Processamento concluído com sucesso!");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine($"String Original:    {original}");
            Console.WriteLine($"String Processada:  {processed}");
            Console.WriteLine();
        }

        public bool AskToContinue()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Deseja processar outra string? (S/N): ");
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

