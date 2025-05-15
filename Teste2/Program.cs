/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite um número.
    2 - A aplicação deve ler essa entrada e garantir que foi digitado um número inteiro, positivo, maior que 0 e menor que 20.
    3 - A aplicação deve gerar uma sequência de Fibonacci com a quantidade de repetições informada pelo usuário.
    Obs: A seguência de Fibonacci segue o padrão 1,1,2,3,5,8 e assim por diante, sendo o próximo número a soma do último número com o seu anterior.
*/

namespace Teste2;

public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número inteiro positivo entre 1 e 19: ");

        string input = Console.ReadLine() ?? string.Empty;

        if (!int.TryParse(input, out int repetitions) || repetitions <= 0 || repetitions >= 20)
        {
            Console.WriteLine("Insira um número inteiro entre 1 e 19.");
            return;
        }

        Console.WriteLine("Sequência de Fibonacci:");
        Console.WriteLine(FibonacciResult(repetitions));
    }

    public static string FibonacciResult(int count)
    {
        var result = new List<int>();
        int a = 1, b = 1;

        for (int i = 0; i < count; i++)
        {
            result.Add(a);
            int next = a + b;
            a = b;
            b = next;
        }

        return string.Join(", ", result);
    }
}
