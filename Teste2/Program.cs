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
        static void Main()
        {
            Console.WriteLine("Digite um número inteiro positivo entre 1 e 19:");
            if (int.TryParse(Console.ReadLine(), out int number) && number > 0 && number < 20)
            {
                Console.WriteLine("Sequência de Fibonacci:");
                GenerateFibonacci(number);
            }
            else
            {
                Console.WriteLine("Número inválido. Tente novamente com um valor entre 1 e 19.");
            }
        }

        static void GenerateFibonacci(int count)
        {
            int previous = 1, current = 1;

            for (int i = 0; i < count; i++)
            {
                Console.Write(previous + (i < count - 1 ? ", " : ""));
                int next = previous + current;
                previous = current;
                current = next;
            }

            Console.WriteLine();
        }
    }
}