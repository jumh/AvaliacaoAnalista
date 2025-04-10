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
            var input = Console.ReadLine();


            while (!ValidateInput(input))
            {
                input = Console.ReadLine();
            }

            GenerateFibonacciSequence(int.Parse(input));
        }


        static bool ValidateInput(string? input)
        {
            if (string.IsNullOrEmpty(input) || !int.TryParse(input, out int number))
            {
                Console.WriteLine("Você deve digitar um número inteiro entre 1 e 19.");
                return false;
            }
            if (number < 1 || number > 19)
            {
                Console.WriteLine("O número deve ser maior que 0 e menor que 20.");
                return false;
            }

            return true;
        }

        static void GenerateFibonacciSequence(int sequenceLength)
        {
            int fA = 1, fB = 1, fC;

            Console.WriteLine("Sequência de Fibonacci:");

            for (int i = 0; i < sequenceLength; i++)
            {
                Console.Write(fA + ",");

                fC = fA + fB;
                fA = fB;
                fB = fC;
            }
        }
    }
}