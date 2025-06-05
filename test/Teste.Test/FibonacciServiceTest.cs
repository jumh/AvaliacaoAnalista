using Teste2.Services.Implementations;

namespace Teste2.Tests.Services;

public class FibonacciServiceTest
{
    [Fact]
    public void GerarSequencia_DeveRetornarDoisElementos_QuandoQuantidadeFor2()
    {
        var service = new FibonacciService();
        var resultado = service.GerarSequencia(2);
        Assert.Equal(2, resultado.Count);
        Assert.Equal(1, resultado[0]);
        Assert.Equal(1, resultado[1]);
    }

    [Fact]
    public void GerarSequencia_DeveRetornarListaVazia_QuandoQuantidadeForNegativa()
    {
        var service = new FibonacciService();
        var resultado = service.GerarSequencia(-5);
        Assert.Empty(resultado);
    }

    [Fact]
    public void GerarSequencia_DeveRetornarListaVazia_QuandoQuantidadeForZero()
    {
        var service = new FibonacciService();
        var resultado = service.GerarSequencia(0);
        Assert.Empty(resultado);
    }

    [Fact]
    public void GerarSequencia_DeveRetornarSequenciaCorreta_QuandoQuantidadeForMaiorQue2()
    {
        var service = new FibonacciService();
        var resultado = service.GerarSequencia(6);
        var esperado = new List<int> { 1, 1, 2, 3, 5, 8 };
        Assert.Equal(esperado, resultado);
    }

    [Fact]
    public void GerarSequencia_DeveRetornarUmElemento_QuandoQuantidadeFor1()
    {
        var service = new FibonacciService();
        var resultado = service.GerarSequencia(1);
        Assert.Single(resultado);
        Assert.Equal(1, resultado[0]);
    }
}
