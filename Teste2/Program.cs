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
            /*logica
            - Pedir um número ao usuário
            - Tentar converter o texto digitado para inteiro (int.Parse)
            - Se a conversão falhar (letra, palavra, vazio) -> avisar e pedir de novo
            - Se converter mas o número não estiver entre 1 e 19 -> avisar e pedir de novo
            - Se estiver entre 1 e 19 -> seguir para o Fibonacci
            - Começar a sequência com previous = 1 e current = 1
            - Imprimir o primeiro 1
            - Repetir até completar a quantidade pedida
            - imprimir o current
            - calcular next = previous + current
            - previous vira current
            - current vira next
            */

            int number;

            while (true) {

                Console.Write("Digite um número de 1 a 19: ");
                string numberStr = Console.ReadLine() ?? "";

                try {
                    number = int.Parse(numberStr);
                    if (number > 0 && number < 20) {
                        break; // número ok -> sai do while
                    }
                    // Caso o número digitado não esteja nesse intervalo
                    Console.WriteLine("O numero deve estar entre 1 e 19. Tente novamente.");
                }
                catch {
                    // Caso tenha uma falha no parse (letra, palavra, vazio)
                    Console.WriteLine("Entrada inválida. Digite um número inteiro entre 1 e 19.");
                }
            }

            int previous = 1;
            int current = 1;

            Console.Write(previous);

            for (int i = 2; i <= number; i++) {
                Console.Write(" " + current);

                int next = previous + current;
                previous = current;
                current = next;
            }

            Console.WriteLine();
        }
    }
}