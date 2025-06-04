using Microsoft.Extensions.Logging;

using Teste1.Services.Interfaces;

namespace Teste1.Services.Implementations;

public class AplicacaoService(
    IValidadorTextoService validadorTexto,
    ILogger<AplicacaoService> logger
) : IAplicacaoService
{
    private readonly ILogger<AplicacaoService> _logger = logger;

    private readonly IValidadorTextoService _validadorTexto = validadorTexto;

    public async Task ExecutarAsync()
    {
        _logger?.LogInformation("Iniciando aplicação...");

        var continuar = true;

        while (continuar)
        {
            Console.WriteLine("\n=== VALIDADOR DE TEXTO ===");
            Console.WriteLine("Digite um texto para validar:");
            var entrada = Console.ReadLine();

            if (string.IsNullOrEmpty(entrada))
            {
                Console.WriteLine("Texto não pode ser vazio!");
                Console.WriteLine("Pressione qualquer tecla para tentar novamente...");
                Console.ReadKey();
                continue;
            }

            if (_validadorTexto is ValidadorTextoService validador)
            {
                validador.DefinirTexto(entrada);
            }

            var ehValido = _validadorTexto.EhValido();
            Console.WriteLine($"\nTexto é válido (apenas letras e números): {ehValido}");

            var textoSemDuplicatas = _validadorTexto.RemoverCaracteresDuplicadosEmSequencia();
            Console.WriteLine($"Texto original: {entrada}");
            Console.WriteLine($"Texto sem duplicatas adjacentes: {textoSemDuplicatas}");

            Console.WriteLine("\nDeseja testar outro texto? (S/N):");
            var resposta = Console.ReadLine();

            continuar =
                !string.IsNullOrEmpty(resposta)
                && (
                    resposta.ToUpperInvariant() == "S"
                    || resposta.ToUpperInvariant() == "SIM"
                    || resposta.ToUpperInvariant() == "Y"
                    || resposta.ToUpperInvariant() == "YES"
                );
        }

        Console.WriteLine("\nObrigado por usar o Validador de Texto!");
        _logger?.LogInformation("Aplicação finalizada com sucesso");

        await Task.CompletedTask;
    }
}
