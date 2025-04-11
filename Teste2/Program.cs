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
            var valid = false;
            var input = "";
            int number = 0;
            do
            {
                Console.Clear();

                Console.WriteLine("Informe o número:");
                input = Console.ReadLine();

                valid = int.TryParse(input, out number);

                if (valid && number > 0 && number < 20)
                {
                    GenerateFibonacci(number);
                }
                else
                {
                    Console.WriteLine("O número precisa ser um inteiro, positivo, maior que 0 e menor que 20");
                    Console.WriteLine("Aperte qualquer tecla para tentar novamente");
                    Console.ReadKey();
                }

            } while (!valid);
        }

        static void GenerateFibonacci(int number)
        {
            Console.Clear();
            var output = "1";

            var last = 1;
            var current = 2;

            for (int i = 2; i <= number; i++)
            {
                output += ", " + last;
                var t = last;
                last = current;
                current = current + t;
            }

            Console.WriteLine(output);

            ShowOptions();
        }

        static void ShowOptions()
        {
            Console.WriteLine("");
            Console.WriteLine("Precione 1 para repetir ou 2 para sair");
            var key = Console.ReadKey().KeyChar.ToString();

            switch (key)
            {
                case "1":
                    Main(args: []);
                    break;
                case "2":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    ShowOptions();
                    break;
            }

        }
    }
}