/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite um número.
    2 - A aplicação deve ler essa entrada e garantir que foi digitado um número inteiro, positivo, maior que 0 e menor que 20.
    3 - A aplicação deve gerar uma sequência de Fibonacci com a quantidade de repetições informada pelo usuário.
    Obs: A seguência de Fibonacci segue o padrão 1,1,2,3,5,8 e assim por diante, sendo o próximo número a soma do último número com o seu anterior.
*/

using System;

namespace Teste2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro positivo entre 1 e 19:");

            int numero;

            string input = Console.ReadLine();

            if (!(int.TryParse(input, out numero) && numero > 0 && numero < 20))
            {
                Console.WriteLine("ERRO. O valor precisa ser um número inteiro positivo e estar entre 1 e 19.");
            }
            else
            {
                Console.WriteLine($"Sequência de Fibonacci com {numero} termos:");

                int a = 1, b = 1, c;

                if (numero >= 1)
                    Console.Write(a);

                if (numero >= 2)
                    Console.Write(", " + b);

                for (int i = 3; i <= numero; i++)
                {
                    c = a + b;
                    Console.Write(", " + c);
                    a = b;
                    b = c;
                }

                Console.WriteLine();
            }
        }
    }
}