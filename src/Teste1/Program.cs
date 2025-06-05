/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite uma string alfanumérica.
    2 - A aplicação deve remover todos os valores duplicados próximos, de forma que não hajam letras/números iguais juntos.
    Exemplo: AAABCCDDD -> Retorno : ABCD
 */

using Microsoft.Extensions.DependencyInjection;

using Teste.Core.Extensions;
using Teste.Core.Services.Interfaces;

namespace Teste1;

internal class Program
{
    public static async Task Main()
    {
        var services = new ServiceCollection().AddMinhaInfraestrutura();
        var serviceProvider = services.BuildServiceProvider();

        try
        {
            var aplicacao = serviceProvider.GetRequiredService<IAplicacaoTest1Service>();
            await aplicacao.ExecutarAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
        finally
        {
            if (serviceProvider is IDisposable disposable)
            {
                disposable.Dispose();
            }
        }
    }
}
