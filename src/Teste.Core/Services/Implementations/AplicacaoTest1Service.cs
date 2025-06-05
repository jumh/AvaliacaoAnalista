using Teste.Core.Services.Interfaces;

namespace Teste.Core.Services.Implementations;

public class AplicacaoTest1Service(IValidadorTextoService validadorTexto) : IAplicacaoTest1Service
{
    private readonly IValidadorTextoService _validadorTexto = validadorTexto;

    public async Task ExecutarAsync()
    {
        var continuar = true;
        var resposta = string.Empty;

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
            if (!ehValido)
            {
                Console.WriteLine("Texto inválido (apenas letras e números) permitidos");
                Console.WriteLine("Deseja testar outro texto? (S/N):");
                resposta = Console.ReadLine();
            }
            else
            {
                var textoSemDuplicatas = _validadorTexto.RemoverCaracteresDuplicadosEmSequencia();
                Console.WriteLine($"Texto original: {entrada}");
                Console.WriteLine($"Texto sem duplicatas adjacentes: {textoSemDuplicatas}");
                Console.WriteLine("Deseja testar outro texto? (S/N):");
                resposta = Console.ReadLine();
            }
            continuar = !string.IsNullOrEmpty(resposta) && (resposta.Equals("S", StringComparison.OrdinalIgnoreCase) || resposta.Equals("SIM", StringComparison.OrdinalIgnoreCase));
        }

        Console.WriteLine("Obrigado por usar o Validador de Texto!");
        await Task.CompletedTask;
    }
}
