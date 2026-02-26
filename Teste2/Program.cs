/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite um número.
    2 - A aplicação deve ler essa entrada e garantir que foi digitado um número inteiro, positivo, maior que 0 e menor que 20.
    3 - A aplicação deve gerar uma sequência de Fibonacci com a quantidade de repetições informada pelo usuário.
    Obs: A seguência de Fibonacci segue o padrão 1,1,2,3,5,8 e assim por diante, sendo o próximo número a soma do último número com o seu anterior.
*/

using System.Text;

namespace Teste2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Digite um número: ");
                if (int.TryParse(Console.ReadLine(), out int numeroUsuario))
                {
                    if (numeroUsuario > 0 && numeroUsuario < 20)
                        Console.WriteLine("Sequência Fibonacci: {0}", RetornaFibonacci(numeroUsuario));
                    else Console.WriteLine("Número inválido");
                }
                else Console.WriteLine("Número inválido");
                Console.WriteLine();
            }
        }

        public static StringBuilder RetornaFibonacci(int qtRepeticao)
        {
            StringBuilder sequenciaFibonacci = new StringBuilder();

            switch (qtRepeticao)
            {
                case 1:
                    sequenciaFibonacci.Append("1");
                    break;

                case 2:
                    sequenciaFibonacci.Append("1, 1");
                    break;

                default:
                    sequenciaFibonacci.Append("1, 1");

                    int primeiroElemento = 1;
                    int segundoElemento = 1;
                    int aux;

                    for (int i = 3; i <= qtRepeticao; i++)
                    {
                        aux = primeiroElemento + segundoElemento;
                        primeiroElemento = segundoElemento;
                        segundoElemento = aux;

                        sequenciaFibonacci.Append($", {aux}");
                    }
                    break;
            }

            return sequenciaFibonacci;
        }
    }
}