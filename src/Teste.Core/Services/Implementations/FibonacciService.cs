using Teste1.Services.Interfaces;

namespace Teste2.Services.Implementations;

public class FibonacciService : IFibonacciService
{
    public List<int> GerarSequencia(int quantidade)
    {
        var sequencia = new List<int>();

        if (quantidade <= 0)
        {
            return sequencia;
        }

        if (quantidade >= 1)
        {
            sequencia.Add(1);
        }

        if (quantidade >= 2)
        {
            sequencia.Add(1);
        }

        for (var i = 2; i < quantidade; i++)
        {
            var proximoNumero = sequencia[i - 1] + sequencia[i - 2];
            sequencia.Add(proximoNumero);
        }

        return sequencia;
    }
}
