/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite uma string alfanumérica.
    2 - A aplicação deve remover todos os valores duplicados próximos, de forma que não hajam letras/números iguais juntos.
    Exemplo: AAABCCDDD -> Retorno : ABCD
 */

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

using Teste1.Services.Implementations;
using Teste1.Services.Interfaces;

namespace Teste1;

public class Program
{
    public static async Task Main(string[] args)
    {
        ServiceCollection services = new();

        services.AddScoped<IValidadorTextoService, ValidadorTextoService>();
        services.AddScoped<IAplicacaoService, AplicacaoService>();

        services.AddLogging(builder =>
        {
            builder.AddSimpleConsole(options =>
            {
                options.IncludeScopes = false;
                options.SingleLine = true;
                options.TimestampFormat = "HH:mm:ss ";
                options.ColorBehavior = LoggerColorBehavior.Enabled;
            });
        });

        ServiceProvider serviceProvider = services.BuildServiceProvider();

        try
        {
            IAplicacaoService aplicacao = serviceProvider.GetRequiredService<IAplicacaoService>();
            await aplicacao.ExecutarAsync();
        }
        catch (Exception exception)
        {
            Console.WriteLine($"Erro na aplicação: {exception.Message}");
        }
        finally
        {
            serviceProvider.Dispose();
        }
    }
}