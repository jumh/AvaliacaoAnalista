using Microsoft.Extensions.DependencyInjection;

using Teste.Core.Services.Implementations;
using Teste.Core.Services.Interfaces;

using Teste1.Services.Interfaces;

using Teste2.Services.Implementations;

namespace Teste.Core.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddMinhaInfraestrutura(this IServiceCollection services)
    {
        services.AddScoped<IValidadorTextoService, ValidadorTextoService>();
        services.AddScoped<IAplicacaoTest1Service, AplicacaoTest1Service>();
        services.AddScoped<IValidadorNumeroService, ValidadorNumeroService>();
        services.AddScoped<IFibonacciService, FibonacciService>();
        services.AddScoped<IAplicacaoTest2Service, AplicacaoTest2Service>();
        return services;
    }
}
