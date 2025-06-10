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
            int quantidade = LerQuantidadeValida();
            GerarSequenciaFibonacci(quantidade);
            Console.WriteLine("\n\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }

        /// <summary>
        /// Solicita ao usuário que digite um número inteiro entre 1 e 19 e valida a entrada.
        /// </summary>
        /// <returns>Um número inteiro válido informado pelo usuário.</returns>
        static int LerQuantidadeValida()
        {
            int numero;

            while (true)
            {
                Console.Write("Digite um número inteiro positivo entre 1 e 19: ");
                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out numero))
                {
                    if (numero > 0 && numero < 20)
                        return numero;
                    else
                        ExibirMensagemErro("O número deve ser maior que 0 e menor que 20.");
                }
                else
                {
                    ExibirMensagemErro("Entrada inválida. Digite um número inteiro.");
                }
            }
        }

        /// <summary>
        /// Gera e exibe a sequência de Fibonacci com o número de termos informado.
        /// </summary>
        /// <param name="quantidade">Quantidade de termos da sequência.</param>
        static void GerarSequenciaFibonacci(int quantidade)
        {
            Console.WriteLine($"\nSequência de Fibonacci com {quantidade} termos:");

            int anterior = 1;
            int atual = 1;

            for (int i = 0; i < quantidade; i++)
            {
                if (i == 0 || i == 1)
                {
                    Console.Write("1 ");
                }
                else
                {
                    int proximo = anterior + atual;
                    Console.Write(proximo + " ");
                    anterior = atual;
                    atual = proximo;
                }
            }
        }

        /// <summary>
        /// Exibe uma mensagem de erro formatada.
        /// </summary>
        /// <param name="mensagem">Mensagem de erro a ser exibida.</param>
        static void ExibirMensagemErro(string mensagem)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Erro: " + mensagem);
            Console.ResetColor();
        }
    }
}