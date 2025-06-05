using Teste2.Services.Implementations;

namespace Teste.Test;

public class ValidadorNumeroServiceTests
{
    [Theory]
    [InlineData("0")]
    [InlineData("-1")]
    [InlineData("20")]
    [InlineData("100")]
    public void EhValido_DeveRetornarFalse_SeNumeroForaDoIntervalo(string input)
    {
        var service = new ValidadorNumeroService();
        service.DefinirNumero(input);

        var resultado = service.EhValido();

        Assert.False(resultado);
    }

    [Theory]
    [InlineData("abc")]
    [InlineData("1.5")]
    [InlineData("!@#")]
    public void EhValido_DeveRetornarFalse_SeNumeroForInvalido(string input)
    {
        var service = new ValidadorNumeroService();
        service.DefinirNumero(input);

        var resultado = service.EhValido();

        Assert.False(resultado);
    }

    [Theory]
    [InlineData("")]
    [InlineData("    ")]
    [InlineData(null)]
    public void EhValido_DeveRetornarFalse_SeNumeroForNuloOuVazio(string input)
    {
        var service = new ValidadorNumeroService();
        service.DefinirNumero(input);

        var resultado = service.EhValido();

        Assert.False(resultado);
    }

    [Fact]
    public void EhValido_DeveRetornarFalse_SeNumeroNaoForDefinido()
    {
        var service = new ValidadorNumeroService();

        var resultado = service.EhValido();

        Assert.False(resultado);
    }

    [Theory]
    [InlineData("1")]
    [InlineData("10")]
    [InlineData("19")]
    public void EhValido_DeveRetornarTrue_SeNumeroValido(string input)
    {
        var service = new ValidadorNumeroService();
        service.DefinirNumero(input);

        var resultado = service.EhValido();

        Assert.True(resultado);
    }

    [Theory]
    [InlineData("1", 1)]
    [InlineData("15", 15)]
    public void ObterNumero_DeveRetornarNumeroAposValidacao(string input, int esperado)
    {
        var service = new ValidadorNumeroService();
        service.DefinirNumero(input);
        service.EhValido();

        var resultado = service.ObterNumero();

        Assert.Equal(esperado, resultado);
    }

    [Fact]
    public void ObterNumero_DeveRetornarZero_SeNumeroNaoForValido()
    {
        var service = new ValidadorNumeroService();
        service.DefinirNumero("abc");
        service.EhValido();

        var resultado = service.ObterNumero();

        Assert.Equal(0, resultado);
    }
}
