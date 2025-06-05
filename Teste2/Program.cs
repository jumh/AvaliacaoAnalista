/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite um número.
    2 - A aplicação deve ler essa entrada e garantir que foi digitado um número inteiro, positivo, maior que 0 e menor que 20.
    3 - A aplicação deve gerar uma sequência de Fibonacci com a quantidade de repetições informada pelo usuário.
    Obs: A sequência de Fibonacci segue o padrão 1,1,2,3,5,8 e assim por diante, sendo o próximo número a soma do último número com o seu anterior.
*/


namespace Teste2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numeroRepeticoes = 0;

            while (true)
            {
                Console.WriteLine("Digite um número:");
                var input = Console.ReadLine();

                if (ValidarNumeroDigitado(input, out numeroRepeticoes))
                    break;

                Console.WriteLine("\nEntrada inválida, tente novamente.\n");
            }

            var fibonacci = GerarSequenciaFibonacci(numeroRepeticoes);

            Console.WriteLine("\nSequência de Fibonacci:");
            Console.WriteLine(string.Join(", ", fibonacci));
        }

        private static bool ValidarNumeroDigitado(string input, out int numeroRepeticoes)
        {
            var ehNumeroConvertido = int.TryParse(input, out numeroRepeticoes);
            return ehNumeroConvertido && numeroRepeticoes > 0 && numeroRepeticoes < 20;
        }

        private static List<int> GerarSequenciaFibonacci(int numeroRepeticoes)
        {
            var resultadoFibonacci = new List<int>();

            if (numeroRepeticoes >= 1)
                resultadoFibonacci.Add(1);

            if (numeroRepeticoes >= 2)
                resultadoFibonacci.Add(1);

            for (int i = 2; i < numeroRepeticoes; i++)
            {
                var ultimoValor = resultadoFibonacci[i - 1];
                var penultimoValor = resultadoFibonacci[i - 2];
                var proximoValor = ultimoValor + penultimoValor;

                resultadoFibonacci.Add(proximoValor);
            }

            return resultadoFibonacci;
        }

    }
}