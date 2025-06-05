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
        private static string message = null;
        static void Main(string[] args)
        {

            Console.WriteLine("Digite um número para começar:");

            var numeroDigitado = Console.ReadLine();

            var numero = ValidarNumero(numeroDigitado);

            if (!string.IsNullOrEmpty(message))
            {
                Console.WriteLine(message);
                return;
            }

            GerarSequenciaFibonacci(numero.Value);
            Console.WriteLine($"Essa é sêquencia: {message}");
        }

        private static void GerarSequenciaFibonacci(int numero)
        {
            int posicaoAnterior = 1;
            int contaAnterior = 1;

            for (var i = 1; i <= numero; i++)
            {
                message += (i <= 1 ? "" : ", ") + posicaoAnterior;

                var contaAtual = posicaoAnterior + contaAnterior;

                posicaoAnterior = contaAnterior;

                contaAnterior = contaAtual;
            }
        }

        private static int? ValidarNumero(string numeroDigitado)
        {
            int? numero = 0;

            if (string.IsNullOrEmpty(numeroDigitado))
            {
                message = "Você precisa digitar um número.";
                return null;
            }

            numero = EhNumero(numeroDigitado);

            if (numero == null)
            {
                message = "O valor digitado não é número inteiro.";
                return null;
            }

            if (!EhNumeroPositivoEntreZeroEVinte(numero.Value))
            {
                message = "O número deve ser maior que 0 e menor que 20.";
            }

            return numero;
        }
        private static int? EhNumero(string numeroDigitado)
        {
            var EhNumero = int.TryParse(numeroDigitado, out int numero);
            if (!EhNumero) return null;

            return numero;
        }
        private static bool EhNumeroPositivoEntreZeroEVinte(int numero)
        {
            if (numero < 1 || numero > 19) return false;

            return true;
        }
    }
}