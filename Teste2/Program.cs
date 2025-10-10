/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite um número.
    2 - A aplicação deve ler essa entrada e garantir que foi digitado um número inteiro, positivo, maior que 0 e menor que 20.
    3 - A aplicação deve gerar uma sequência de Fibonacci com a quantidade de repetições informada pelo usuário.
    Obs: A seguência de Fibonacci segue o padrão 1,1,2,3,5,8 e assim por diante, sendo o próximo número a soma do último número com o seu anterior.
*/

using Teste2.Controllers;
using Teste2.Services;
using Teste2.Views;

namespace Teste2
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
                var fibonacciService = new FibonacciService();

                // Inicialização do controller
                var controller = new FibonacciController(
                    view,
                    validationService,
                    fibonacciService
                );

                // Execução da aplicação
                controller.Run();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nErro fatal: {ex.Message}");
                Console.ResetColor();
                Console.WriteLine("\nPressione qualquer tecla para sair...");
                Console.ReadKey();
            }
        }
    }
}
