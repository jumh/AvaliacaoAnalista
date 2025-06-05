/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite um número.
    2 - A aplicação deve ler essa entrada e garantir que foi digitado um número inteiro, positivo, maior que 0 e menor que 20.
    3 - A aplicação deve gerar uma sequência de Fibonacci com a quantidade de repetições informada pelo usuário.
    Obs: A seguência de Fibonacci segue o padrão 1,1,2,3,5,8 e assim por diante, sendo o próximo número a soma do último número com o seu anterior.
*/

using Microsoft.Extensions.DependencyInjection;

using Teste.Core.Extensions;
using Teste.Core.Services.Interfaces;

namespace Teste2;

public class Program
{
    public static async Task Main()
    {
        var services = new ServiceCollection().AddMinhaInfraestrutura();
        var serviceProvider = services.BuildServiceProvider();

        try
        {
            var aplicacao = serviceProvider.GetRequiredService<IAplicacaoTest2Service>();
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
