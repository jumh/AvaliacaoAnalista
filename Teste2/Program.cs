using System;
/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite um número.
    2 - A aplicação deve ler essa entrada e garantir que foi digitado um número inteiro, positivo, maior que 0 e menor que 20.
    3 - A aplicação deve gerar uma sequência de Fibonacci com a quantidade de repetições informada pelo usuário.
    Obs: A seguência de Fibonacci segue o padrão 1,1,2,3,5,8 e assim por diante, sendo o próximo número a soma do último número com o seu anterior.
*/

namespace Teste2
{
    class Program
    {
        static void Main(string[] args)
        {
            var quantity = GetCountFromUser();

            Console.WriteLine($"\nSequência de Fiboanacci com {quantity} termo(s):");
            Console.WriteLine(GenerateFibonacciSequence(quantity));
        }

        static int GetCountFromUser()
        {
            while (true)
            {
                Console.Write("Digite um número inteiro entre 1 e 19: ");

                var input = Console.ReadLine()?.Trim();

                if (int.TryParse(input, out int quantity) && quantity > 0 && quantity < 20)
                    return quantity;

                Console.WriteLine("Entrada inválida. Entre com um número inteiro, positivo, maior que 0 e menor que 20.");
            }
        }

        static string GenerateFibonacciSequence(int quantity)
        {
            int previous = 0, current = 1;
           
            var sequence = new System.Text.StringBuilder();
            
            for (int i = 0; i < quantity; i++)
            {
                if (i > 0)
                    sequence.Append(", ");
            
                sequence.Append(current);
                
                int next = previous + current;
                
                previous = current;
                
                current = next;
            }
            
            return sequence.ToString();
        }
    }
}