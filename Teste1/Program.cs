/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite uma string alfanumérica.
    2 - A aplicação deve remover todos os valores duplicados próximos, de forma que não hajam letras/números iguais juntos.
    Exemplo: AAABCCDDD -> Retorno : ABCD
 */

using Teste1.Controllers;
using Teste1.Services;
using Teste1.Views;

namespace Teste1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Configuração de dependências (Dependency Injection manual)
                var view = new ConsoleView();
                var validationService = new InputValidationService();
                var deduplicationService = new StringDeduplicationService();

                // Inicialização do controller
                var controller = new StringProcessController(
                    view,
                    validationService,
                    deduplicationService
                );

                // Execução da aplicação
                controller.Run();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n❌ Erro fatal: {ex.Message}");
                Console.ResetColor();
                Console.WriteLine("\nPressione qualquer tecla para sair...");
                Console.ReadKey();
            }
        }
    }
}