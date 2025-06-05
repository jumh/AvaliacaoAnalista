using Teste.Core.Services.Interfaces;

using Teste1.Services.Interfaces;

namespace Teste2.Services.Implementations;

public class AplicacaoTest2Service(
    IValidadorNumeroService validadorNumero,
    IFibonacciService fibonacciService
) : IAplicacaoTest2Service
{
    private readonly IFibonacciService _fibonacciService = fibonacciService;

    private readonly IValidadorNumeroService _validadorNumero = validadorNumero;

    public async Task ExecutarAsync()
    {
        var continuar = true;
        var resposta = string.Empty;
        while (continuar)
        {
            Console.WriteLine("\n=== GERADOR DE SEQUÊNCIA FIBONACCI ===");
            Console.WriteLine("Digite um número inteiro positivo (entre 1 e 19):");

            var entrada = Console.ReadLine();

            if (string.IsNullOrEmpty(entrada))
            {
                Console.WriteLine("Entrada não pode ser vazia!");
                Console.WriteLine("Pressione qualquer tecla para tentar novamente...");
                Console.ReadKey();
                continue;
            }

            _validadorNumero.DefinirNumero(entrada);
            if (!_validadorNumero.EhValido())
            {
                Console.WriteLine("Número inválido! Digite um número inteiro positivo entre 1 e 19.");
                Console.WriteLine("Pressione qualquer tecla para tentar novamente...");
                Console.WriteLine("Deseja gerar outra sequência? (S/N):");
                resposta = Console.ReadLine();
            }
            else
            {
                var quantidade = _validadorNumero.ObterNumero();
                var sequenciaFibonacci = _fibonacciService.GerarSequencia(quantidade);
                Console.WriteLine($"Sequência de Fibonacci com {quantidade} número(s):");
                Console.WriteLine(string.Join(", ", sequenciaFibonacci));
                Console.WriteLine("Deseja gerar outra sequência? (S/N):");
                resposta = Console.ReadLine();
            }
            continuar = !string.IsNullOrEmpty(resposta) && (resposta.Equals("S", StringComparison.OrdinalIgnoreCase) || resposta.Equals("SIM", StringComparison.OrdinalIgnoreCase));
        }

        Console.WriteLine("Obrigado por usar o Gerador de Fibonacci!");
        await Task.CompletedTask;
    }
}
