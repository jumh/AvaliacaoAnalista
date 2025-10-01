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

            int quantidade = 0;

            while (true)
            {
                Console.Write("Digite um número inteiro entre 1 e 19: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out quantidade) || quantidade <= 0 || quantidade >= 20)
                {
                    Console.WriteLine("Entrada inválida! Tente novamente.");
                    continue;
                }

                break; 
            }

            long[] fibonacci = GerarFibonacci(quantidade);

            Console.WriteLine("Sequência de Fibonacci:");
            Console.WriteLine(string.Join(", ", fibonacci));
        }

        static long[] GerarFibonacci(int n)
        {
            long[] sequencia = new long[n];

            for (int i = 0; i < n; i++)
            {
                if (i == 0 || i == 1)
                    sequencia[i] = 1; 
                else
                    sequencia[i] = sequencia[i - 1] + sequencia[i - 2];
            }

            return sequencia;
        }
    }
}