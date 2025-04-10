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
            Console.WriteLine("Digite um número inteiro entre 1 e 19:");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int quantidade) || quantidade <= 0 || quantidade >= 20)
            {
                Console.WriteLine("Entrada inválida! Digite um número inteiro maior que 0 e menor que 20.");
                return;
            }

            Console.WriteLine($"Sequência de Fibonacci com {quantidade} números:");
            GerarFibonacci(quantidade);
        }

        static void GerarFibonacci(int quantidade)
        {
            int primeiro = 1, segundo = 1;

            if (quantidade == 1)
            {
                Console.WriteLine(primeiro);
                return;
            }

            Console.Write($"{primeiro}, {segundo}");

            for (int i = 2; i < quantidade; i++)
            {
                int proximo = primeiro + segundo;
                Console.Write($", {proximo}");
                primeiro = segundo;
                segundo = proximo;
            }
            Console.WriteLine(); 
        }
    }
}