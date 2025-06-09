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
            Console.WriteLine("Digite um número que seja inteiro, positivo, maior que 0 e menor que 20:");

            int param = 0;
            bool valid = false;

            while (!valid)
            {
                string input = Console.ReadLine();

                if (int.TryParse(input, out param) && param > 0 && param < 20)
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro, positivo, maior que 0 e menor que 20:");
                }
            }

            List<int> fibonacci = new List<int>();

            if (param >= 1)
                fibonacci.Add(1);
            if (param >= 2)
                fibonacci.Add(1);

            for (int i = 2; i < param; i++)
            {
                fibonacci.Add(fibonacci[i - 1] + fibonacci[i - 2]);
            }

            Console.WriteLine($"Fibonacci com {param} elementos:");

            bool first = true;
            foreach (int item in fibonacci)
            {
                if (!first)
                {
                    Console.Write(", ");
                }
                Console.Write(item);
                first = false;
            }

            Console.WriteLine();
        }
    }
}