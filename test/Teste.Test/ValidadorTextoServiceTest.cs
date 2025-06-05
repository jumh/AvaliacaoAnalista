using Teste.Core.Services.Implementations;

namespace Teste.Test
{
    public class ValidadorTextoServiceTests
    {
        [Theory]
        [InlineData("abc!123")]
        [InlineData("abc 123")]
        [InlineData("a_b_c")]
        [InlineData("123-456")]
        public void EhValido_DeveRetornarFalse_SeTextoContiverCaractereNaoAlfanumerico(string texto)
        {
            var service = new ValidadorTextoService();
            service.DefinirTexto(texto);

            var resultado = service.EhValido();

            Assert.False(resultado);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void EhValido_DeveRetornarFalse_SeTextoForNuloOuVazio(string texto)
        {
            var service = new ValidadorTextoService();
            service.DefinirTexto(texto);

            var resultado = service.EhValido();

            Assert.False(resultado);
        }

        [Fact]
        public void EhValido_DeveRetornarFalse_SeTextoNaoDefinido()
        {
            var service = new ValidadorTextoService();

            var resultado = service.EhValido();

            Assert.False(resultado);
        }

        [Theory]
        [InlineData("abc123")]
        [InlineData("A1B2C3")]
        [InlineData("zYxW987")]
        public void EhValido_DeveRetornarTrue_SeTextoForAlfanumerico(string texto)
        {
            var service = new ValidadorTextoService();
            service.DefinirTexto(texto);

            var resultado = service.EhValido();

            Assert.True(resultado);
        }

        [Theory]
        [InlineData("aabbcc", "abc")]
        [InlineData("AAbbCC", "AbC")]
        [InlineData("aAaaAA", "a")]
        [InlineData("abc", "abc")]
        [InlineData("a", "a")]
        [InlineData("", "")]
        public void RemoverCaracteresDuplicadosEmSequencia_DeveRemoverDuplicadosIgnorandoCase(string texto, string esperado)
        {
            var service = new ValidadorTextoService();
            service.DefinirTexto(texto);

            var resultado = service.RemoverCaracteresDuplicadosEmSequencia();

            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void RemoverCaracteresDuplicadosEmSequencia_DeveRetornarStringVazia_SeTextoNaoDefinido()
        {
            var service = new ValidadorTextoService();

            var resultado = service.RemoverCaracteresDuplicadosEmSequencia();

            Assert.Equal(string.Empty, resultado);
        }
    }
}
