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
        public static void Main(string[] args)
        {
            Console.WriteLine("=== Gerador de Sequência de Fibonacci Simples ===");

            int n;
            const int MIN = 1;
            const int MAX = 19;

            while (true)
            {
                Console.Write($"\nDigite um número inteiro (entre {MIN + 1} e {MAX}): ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out n))
                {
                    Console.WriteLine("Erro: O valor digitado não é um número inteiro válido.");
                    continue;
                }

                if (n <= MIN || n > MAX)
                {
                    Console.WriteLine($"Erro: O número deve ser maior que {MIN} e menor que {MAX + 1}.");
                    continue;
                }

                break;
            }


            

            // Exibe o resultado
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Sequência de Fibonacci: {string.Join(", ", RetornarSequenciaFibonacci(n))}");
            Console.ResetColor();

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }

        public static List<int> RetornarSequenciaFibonacci(int n)
        {
            var sequencia = new List<int>();
            int anterior = 1;
            int atual = 1;

            for (int i = 1; i <= n; i++)
            {
                sequencia.Add(anterior);

                int proximo = anterior + atual;

                anterior = atual;
                atual = proximo;
            }
            return sequencia;
        }
    }
}