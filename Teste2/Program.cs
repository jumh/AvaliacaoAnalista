/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite um número.
    2 - A aplicação deve ler essa entrada e garantir que foi digitado um número inteiro, 
positivo, maior que 0 e menor que 20.
    3 - A aplicação deve gerar uma sequência de Fibonacci com a quantidade de repetições 
informada pelo usuário.
    Obs: A seguência de Fibonacci segue o padrão 1,1,2,3,5,8 e assim por diante, sendo o 
próximo número a soma do último número com o seu anterior.
*/

namespace Teste2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool encerrarTeste = false;
            Console.WriteLine("Bem vindo ao Teste2");
            IniciarTesteSequenciaFibonacci(); //-> Teste
            Console.WriteLine("Obrigado por ter feito meu teste ;)");
            Console.ReadKey();

        }

        /// <summary>
        /// Método facilitador para ser reutilizavel caso o usuario erre o teste, ofereça pra ele fazer novamente.
        /// </summary>
        static void FacilitarRefazerTeste()
        {
            Console.WriteLine("Que tal tentar novamente? (S/N)");
            string respostaFacilitador = Console.ReadLine() ?? string.Empty;
            if (respostaFacilitador.Trim().Equals("s"))
            {
                Console.Clear();
                IniciarTesteSequenciaFibonacci();
            }
        }

        /// <summary>
        /// Regra para validar se o numero digitado esta dentro da condição de positivo maior que 0 e menor que 20;
        /// </summary>
        /// <param name="valor"></param>
        /// <returns>Boleano pra validação (true, false)</returns>
        static bool AplicarValidacaoEntradaDadosTeste(int valor)
        {
            //Lógica isolada para o principio do solid 
            return valor > 0 && valor < 20 ? true : false;
        }

        /// <summary>
        /// Metodo para tratar a conversão do valor digitado em especifico.
        /// </summary>
        /// <param name="entrada"></param>
        /// <param name="numero"></param>
        /// <returns></returns>
        static bool TentarConverterParaInteiro(string entrada, out int numero)
        {
            return int.TryParse(entrada, out numero);
        }


        static void IniciarTesteSequenciaFibonacci()
        {
            Console.WriteLine("Vamos gerar uma sequência de Fibonacci!");
            Console.WriteLine("Por favor, digite um número inteiro **maior que 0 e menor que 20** para saber os primeiros valores da sequência:");
            Console.WriteLine("(Exemplo: se digitar 6, você verá: 1, 1, 2, 3, 5, 8)");

            string valorDigitado = Console.ReadLine() ?? string.Empty;
            bool validadorConversaoInt = TentarConverterParaInteiro(valorDigitado, out int numeroConvertido);

            if (validadorConversaoInt)
            {
                bool validadorRegraEntrada = AplicarValidacaoEntradaDadosTeste(numeroConvertido);
                if (validadorRegraEntrada)
                {
                    Console.WriteLine($"A sequencia Fibonacci para o número {numeroConvertido} é:");
                    Console.WriteLine(RetornaSequenciaFibonacci(numeroConvertido));
                }
                else
                    Console.WriteLine("Esse valor digitado não atende as regras de um número inteiro **maior que 0 e menor que 20** ");
            }
            else
                Console.WriteLine("Esse valor digitado não é um número inteiro!");

            FacilitarRefazerTeste();
        }

        static string RetornaSequenciaFibonacci(int numeroSequencia)
        {
            string sequenciaFibonacci = "1"; //Inicia a sequencia fibonacci por (1)

            int numeroUltimo = 1;
            int numeroPenultimo = 0;
            for (var x = 1; x < numeroSequencia; x++)
            {
                var calculoFibonacci = numeroUltimo + numeroPenultimo;
                sequenciaFibonacci += "," + calculoFibonacci;

                numeroPenultimo = numeroUltimo;
                numeroUltimo = calculoFibonacci;
            }

            return sequenciaFibonacci;
        }
    }
}