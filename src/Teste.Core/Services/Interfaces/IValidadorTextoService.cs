namespace Teste.Core.Services.Interfaces;

public interface IValidadorTextoService
{
    bool EhValido();

    string RemoverCaracteresDuplicadosEmSequencia();
}