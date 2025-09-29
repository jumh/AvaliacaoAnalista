/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite um número.
    2 - A aplicação deve ler essa entrada e garantir que foi digitado um número inteiro, positivo, maior que 0 e menor que 20.
    3 - A aplicação deve gerar uma sequência de Fibonacci com a quantidade de repetições informada pelo usuário.
    Obs: A seguência de Fibonacci segue o padrão 1,1,2,3,5,8 e assim por diante, sendo o próximo número a soma do último número com o seu anterior.
*/

namespace Teste2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.Write("Digite um número inteiro entre 1 e 19: ");
            string? input = Console.ReadLine();

            if (!int.TryParse(input, out int n))
            {
                Console.WriteLine("Valor inválido: não é um número inteiro.");
                return;
            }

            if (n <= 0 || n >= 20)
            {
                Console.WriteLine("Valor inválido: deve ser maior que 0 e menor que 20.");
                return;
            }

            var fib = GerarFibonacci(n);
            Console.WriteLine("Sequência de Fibonacci com " + n + " termos:");
            Console.WriteLine(string.Join(", ", fib));
        }

        static int[] GerarFibonacci(int n)
        {
            int[] seq = new int[n];

            if (n >= 1)
                seq[0] = 1;

            if (n >= 2)
                seq[1] = 1;

            for (int i = 2; i < n; i++)
            {
                seq[i] = seq[i - 1] + seq[i - 2];
            }

            return seq;
        }
    }
}