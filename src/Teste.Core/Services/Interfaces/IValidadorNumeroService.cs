namespace Teste1.Services.Interfaces;

public interface IValidadorNumeroService
{
    void DefinirNumero(string numero);

    bool EhValido();

    int ObterNumero();
}
