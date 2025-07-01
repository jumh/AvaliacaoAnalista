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
            int num = VerifiyNum();
            int[] fibonacciSeq = GenerateFibonacciSequence(num);

            ShowSequence(fibonacciSeq);
            Console.ReadKey();
        }

        static int VerifiyNum()
        {
            int num;
            do
            {
                Console.Write("Digite um número inteiro positivo entre 1 e 20: ");
                string? input = Console.ReadLine();
                if (!int.TryParse(input, out num) || num <= 0 || num >= 20)
                {
                    Console.WriteLine("Número inválido. Tente novamente.");
                }
            } while (num <= 0 || num >= 20);
            return num;
        }

        static int[] GenerateFibonacciSequence(int num)
        {
            int[] fibonacci = new int[num];
            if (num >= 1) fibonacci[0] = 1;
            if (num >= 2) fibonacci[1] = 1;
            for (int i = 2; i < num; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }
            return fibonacci;
        }

        static void ShowSequence(int[] fibonacciSeq)
        {
            Console.WriteLine("Sequência de Fibonacci:");
            foreach (int number in fibonacciSeq)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}