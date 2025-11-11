/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite um número.
    2 - A aplicação deve ler essa entrada e garantir que foi digitado um número inteiro, positivo, maior que 0 e menor que 20.
    3 - A aplicação deve gerar uma sequência de Fibonacci com a quantidade de repetições informada pelo usuário.
    Obs: A seguência de Fibonacci segue o padrão 1,1,2,3,5,8 e assim por diante, sendo o próximo número a soma do último número com o seu anterior.
*/

namespace Teste2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Boa sorte!");
            int n = 0;
            while (true)
            {
                Console.WriteLine("Digite um número inteiro positivo entre 1 e 20:");
                string input = Console.ReadLine();

                if (int.TryParse(input, out n) && n > 0 && n < 20)
                {
                    break; 
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, tente novamente.");
                }
            }

            List<int> fibonacciSequence = GenerateFibonacci(n);
            Console.WriteLine($"\nSequência de Fibonacci com {n} termos:");
            Console.WriteLine(string.Join(", ", fibonacciSequence));
            Console.WriteLine("\nFim da execução.");

            static List<int> GenerateFibonacci(int n)
            {
                List<int> sequence = new List<int> { 1 };

                if (n == 1) return sequence;

                sequence.Add(1);

                for (int i = 3; i <= n; i++)
                {
                    int next = sequence[^1] + sequence[^2];
                    sequence.Add(next);
                }

                return sequence;
            }
          
        }
    }
}