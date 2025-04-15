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
            int quantidade = SolicitarEntrada();
            CalcularSequenciaFibonacci(quantidade);
        }

        static int SolicitarEntrada()
        {
            Console.Write("Digite um número inteiro entre 1 e 19: ");
            string entrada = Console.ReadLine();

            ValidarEntrada(entrada, out int numeroValido);

            return numeroValido;
        }

        static void ValidarEntrada(string entrada, out int numero)
        {
            bool ehNumero = int.TryParse(entrada, out numero);

            if (!ehNumero || numero <= 0 || numero >= 20)
            {
                Console.WriteLine("Erro: Como o valor não atende aos requisitos o programa será encerrado.");
                Environment.Exit(1);
            }
        }

        static void CalcularSequenciaFibonacci(int quantidade)
        {
            Console.WriteLine("Sequência de Fibonacci:");

            int anterior = 1, atual = 1;

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write(i == 0 ? $"{anterior}" : $", {anterior}");
                int proximo = anterior + atual;
                anterior = atual;
                atual = proximo;
            }
        }
    }
}