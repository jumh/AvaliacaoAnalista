/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite um número.
    2 - A aplicação deve ler essa entrada e garantir que foi digitado um número inteiro, positivo, maior que 0 e menor que 20.
    3 - A aplicação deve gerar uma sequência de Fibonacci com a quantidade de repetições informada pelo usuário.
    Obs: A seguência de Fibonacci segue o padrão 1,1,2,3,5,8 e assim por diante, sendo o próximo número a soma do último número com o seu anterior.
*/

namespace Teste2;

internal class Program
{
    static void Main(string[] args)
    {
        int number;

        for (; ; )
        {
            Console.WriteLine("Digite um número inteiro positivo, maior que 0 e menor que 20:");
            var input = Console.ReadLine();
            if (int.TryParse(input, out number) && number > 0 && number < 20)
            {
                break;
            }
            Console.WriteLine("Entrada inválida. Por favor, tente novamente.");
        }

        Console.WriteLine("Sequência de Fibonacci:");
        if (number == 1)
        {
            Console.WriteLine("1");
        }
        else
        {
            var a = 1;
            var b = 1;
            Console.Write($"{a}, {b}");
            for (var i = 2; i < number; i++)
            {
                var next = a + b;
                Console.Write($", {next}");
                a = b;
                b = next;
            }
            Console.WriteLine();
        }
    }
}
