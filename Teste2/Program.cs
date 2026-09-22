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
            bool valido = true;
            var numeroSequencia = 0;
            while (valido)
            {
                Console.WriteLine("Digite um número entre 0 e 20: ");
                var numero = Console.ReadLine();

                var conversao = int.TryParse(numero, out int numeroConvertido);
                if (conversao)
                {
                    if (numeroConvertido < 0 || numeroConvertido > 20)
                    {
                        Console.WriteLine("O número digitado tem de ser menor que 20 ou maior que 0");
                    }
                    else
                    {
                        Console.WriteLine("O número digitado está dentro do intervalo permitido (0 a 20)");
                        valido = false;
                    }
                }

                numeroSequencia = numeroConvertido;
            }
            List<int> fibonnaci = new List<int>();

            for (int i = 0; i < numeroSequencia; i++)
            {
                if (i == 0)
                {
                    fibonnaci.Add(1);
                }
                else if (i == 1)
                {
                    fibonnaci.Add(1);
                }
                else
                {
                    fibonnaci.Add(fibonnaci[i - 1] + fibonnaci[i - 2]);
                }
            }

            foreach (var item in fibonnaci)
            {
                Console.WriteLine($"O valor da sequencia de Fibonacci é: {item}");
            }

        }
    }
}