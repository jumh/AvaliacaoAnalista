using System.Text;

using Teste1.Services.Interfaces;

namespace Teste1.Services.Implementations;

public class ValidadorTextoService : IValidadorTextoService
{
    private string? _texto;

    public void DefinirTexto(string texto) => _texto = texto;

    public bool EhValido()
    {
        if (string.IsNullOrEmpty(_texto))
            return false;

        foreach (char caractere in _texto)
        {
            if (!char.IsLetterOrDigit(caractere))
                return false;
        }

        return true;
    }

    public string RemoverCaracteresDuplicadosEmSequencia()
    {
        if (string.IsNullOrEmpty(_texto))
            return _texto ?? string.Empty;

        StringBuilder resultado = new();
        char anterior = '\0';

        foreach (char caractere in _texto)
        {
            if (char.ToLowerInvariant(caractere) != char.ToLowerInvariant(anterior))
            {
                resultado.Append(caractere);
                anterior = caractere;
            }
        }

        return resultado.ToString();
    }
}