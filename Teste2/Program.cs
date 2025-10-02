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
            string? userInput;

            //loop até que o input do usuário seja válido
            int number;
            while (true)
            {
                Console.Write("Digite um número inteiro, positivo, maior que 0 e menor que 20: ");

                var input = Console.ReadLine();

                var result = GetValidInput(input);

                if (result.HasValue)
                {
                    number = result.Value;
                    break;
                }

                Console.WriteLine("Entrada inválida. Tente novamente.\n");
            }

            // crio o array com o tamanho informado pelo usuário. Não há necessidade de me preocupar com overflow e uso de long por ex.
            // uma vez que o input é limitado à 20
            int[] fibonacciArray = new int[number];

            for (int i = 0; i < number; i++)
            {
                //os dois primeiros números da sequência são sempre 1
                if (i is 0 || i is 1)
                {
                    fibonacciArray[i] = 1;

                    //aqui garanto o early continue, para evitar acessar índices negativos
                    continue;
                }

                //aqui eu garanto que o índice 0 e 1 já foram tratados, então posso acessar os dois índices anteriores sem validação
                //optei por esse formato de cálculo, pois entendo que melhora a legibilidade do código, além de economizar memória declarando menos variáveis
                fibonacciArray[i] = fibonacciArray[i - 1] + fibonacciArray[i - 2];
            }

            Console.WriteLine($"Sequência de Fibonacci: {string.Join(",", fibonacciArray)}");
        }

        static int? GetValidInput(string? userInput)
        {
            //verifico se é nulo ou vazio
            if (!int.TryParse(userInput, out int number))
                return null;

            //verifico se cumpre o requisito de ser maior que 0 e menor que 20
            if (number <= 0 || number >= 20)
                return null;

            return number;
        }
    }
}