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
            Console.WriteLine("Informe um número maior que 0 e menor que 20: ");
            string? numeroFibonacciInformado = Console.ReadLine();

            Console.WriteLine("Informe um número de repetições: ");
            string? numeroRepeticoesInformado = Console.ReadLine();
            
            if(!ValidarNumeroInformado(numeroFibonacciInformado)) return;
            if(!ValidarNumeroInformado(numeroRepeticoesInformado)) return;

            int numeroFibonacciConvertido = Int32.Parse(numeroFibonacciInformado); 
            int numeroRepeticoesConvertido = Int32.Parse(numeroRepeticoesInformado); 
            List<int> sequenciaFibonacci = GerarSequenciaFibonacci(numeroFibonacciConvertido, numeroRepeticoesConvertido);
            
            Console.WriteLine($"Sequencia Fibonnaci Gerada: {string.Join(",", sequenciaFibonacci)}");
        }
        static List<int> GerarSequenciaFibonacci(int inicioFibonnaci, int repeticoes)
        {
            List<int> sequencialAtual = new List<int>{ 0, inicioFibonnaci };

            for(int c = 1; c < repeticoes; c++)
            {
                var resultado = sequencialAtual[sequencialAtual.Count() - 2] + sequencialAtual[sequencialAtual.Count() - 1]; ;
                sequencialAtual.Add(resultado);
            }

            //Removendo o zero para exibir o número informado pelo usuário
            sequencialAtual.RemoveAt(0);

            return sequencialAtual;
        }

        static bool ValidarNumeroInformado(string numero)
        {
            if (String.IsNullOrEmpty(numero.Trim()))
            {
                Console.WriteLine("Número não informado");
                return false;
            }

            int tentativaConversao = 0;
            bool conversao = Int32.TryParse(numero, null, out tentativaConversao);

            if (!conversao)
            {
                Console.WriteLine("Falha na conversão: número informado é inválido");
                return false;
            }

            if(tentativaConversao < 0)
            {
                Console.WriteLine("Número informado é menor que 0");
                return false;
            }

            if(tentativaConversao > 20)
            {
                Console.WriteLine("Número informado é maior que 20");
                return false;
            }

            return true;
        }
    }
}