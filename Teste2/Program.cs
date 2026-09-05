/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite um número.
    2 - A aplicação deve ler essa entrada e garantir que foi digitado um número inteiro, positivo, maior que 0 e menor que 20.
    3 - A aplicação deve gerar uma sequência de Fibonacci com a quantidade de repetições informada pelo usuário.
    Obs: A seguência de Fibonacci segue o padrão 1,1,2,3,5,8 e assim por diante, sendo o próximo número a soma do último número com o seu anterior.
*/

using System.Reflection.Metadata.Ecma335;

namespace Teste2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Digite um número entre 1 e 19: ");

            numero = int.Parse(Console.ReadLine() ?? "1");

            if(!inputIntValidation(numero))
            {
                Console.WriteLine("Número inválido. Digite um número entre 1 e 19.");
                return;
            }

            string fibonacciSequence = GenerateFibonacciSequence(numero);
            Console.WriteLine($"Sequência de Fibonacci: {fibonacciSequence}");

        }

        public static bool inputIntValidation(int numero)
        {
            if (numero < 1 || numero > 19)
            {
                return false;
            }
            return true;
        }

        public static string GenerateFibonacciSequence(int numero)
        {
            if (numero <= 0)
            {
                return string.Empty;
            }
            int[] fibonacci = new int[numero];
            fibonacci[0] = 1;
            if (numero > 1)
            {
                fibonacci[1] = 1;
                for (int i = 2; i < numero; i++)
                {
                    fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                }
            }
            return string.Join(", ", fibonacci);
        }
    }
}