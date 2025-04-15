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
            Console.Write("Digite um número inteiro entre 1 e 19: ");
            var input = Console.ReadLine();

            if (!int.TryParse(input, out int quantidade) || quantidade < 1 || quantidade >= 20)
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro positivo entre 1 e 19.");
                return;
            }

            var sequencia = GerarFibonacci(quantidade);
            Console.WriteLine("Sequência de Fibonacci:");
            Console.WriteLine(string.Join(", ", sequencia));
        }

        private static List<int> GerarFibonacci(int n)
        {
            var resultado = new List<int>();

            if (n >= 1) resultado.Add(1);
            if (n >= 2) resultado.Add(1);

            for (int i = 2; i < n; i++)
            {
                int proximo = resultado[i - 1] + resultado[i - 2];
                resultado.Add(proximo);
            }

            return resultado;
        }
    }
}