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
            Console.WriteLine("Gerador de sequência Fibonacci");
            Console.WriteLine("Quantos números da sequência devem ser gerados? (Máx. 19)");

            if(!int.TryParse(Console.ReadLine(), out int limit)) throw new Exception("O valor precisa ser um número inteiro");
            if(limit <= 0 || limit >= 20) throw new Exception("O valor precisa estar entre 1 e 19");

            Console.WriteLine("\nGerando sequência: ");
            foreach(int value in FibonacciGenerator().Take(limit)) {
                Console.WriteLine(value);
            }

        }

        static IEnumerable<int> FibonacciGenerator()
        {
            int[] lastInts = [0, 1];
            while (true) {
                yield return lastInts[1];
                (lastInts[0], lastInts[1]) = (lastInts[1], lastInts[0] + lastInts[1]);
            }
        }
    }
}