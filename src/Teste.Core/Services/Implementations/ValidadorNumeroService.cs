using Teste1.Services.Interfaces;

namespace Teste2.Services.Implementations;

public class ValidadorNumeroService : IValidadorNumeroService
{
    private int _numero;

    private string? _numeroTexto;

    public void DefinirNumero(string numero)
    {
        _numeroTexto = numero;
    }

    public bool EhValido()
    {
        if (string.IsNullOrWhiteSpace(_numeroTexto))
        {
            return false;
        }

        if (!int.TryParse(_numeroTexto, out _numero))
        {
            return false;
        }

        return _numero > 0 && _numero < 20;
    }

    public int ObterNumero()
    {
        return _numero;
    }
}
