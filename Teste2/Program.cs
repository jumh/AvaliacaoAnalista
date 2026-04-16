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
        static string GerarFibonacci(int repeticoes)
        {
            string sequencia = "";
            int anterior = 1;
            int atual = 1;

            for (int i = 0; i < repeticoes; i++)
            {
                if (i == 0 || i == 1)
                {
                    sequencia += "1";
                }
                else
                {
                    int proximo = anterior + atual;
                    sequencia += proximo;
                    anterior = atual;
                    atual = proximo;
                }

                if (i < repeticoes - 1)
                {
                    sequencia += ",";
                }
            }

            return sequencia;
        }

        static void Main(string[] args)
        {
            int numero;
            string entrada;

            do
            {
                Console.Write("Digite um número inteiro entre 1 e 19: ");
                entrada = Console.ReadLine() ?? "";
            }
            while (!Int32.TryParse(entrada, out numero) || numero <= 0 || numero >= 20);

            string fibonacci = GerarFibonacci(numero);
            Console.WriteLine("Sequência: " + fibonacci);
        }
    }
}