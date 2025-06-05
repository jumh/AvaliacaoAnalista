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
            int quantidade = ObterQuantidadeValida();
            ExibirSequenciaFibonacci(quantidade);
        }

        static int ObterQuantidadeValida()
        {
            int quantidade;

            while (true)
            {
                Console.Write("Digite um número inteiro positivo entre 1 e 19 para gerar a sequência de Fibonacci: ");
                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out quantidade) && quantidade > 0 && quantidade < 20)
                {
                    return quantidade;
                }

                Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro entre 1 e 19.\n");
            }
        }

        static void ExibirSequenciaFibonacci(int quantidade)
        {
            Console.WriteLine($"\nSequência de Fibonacci com {quantidade} elemento(s):");

            int a = 1, b = 1;

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write(a + (i < quantidade - 1 ? ", " : "\n"));

                int temp = a;
                a = b;
                b = temp + b;
            }
        }
    }
}