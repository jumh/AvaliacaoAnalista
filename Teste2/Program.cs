/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite um número.
    2 - A aplicação deve ler essa entrada e garantir que foi digitado um número inteiro, positivo, maior que 0 e menor que 20.
    3 - A aplicação deve gerar uma sequência de Fibonacci com a quantidade de repetições informada pelo usuário.
    Obs: A seguência de Fibonacci segue o padrão 1,1,2,3,5,8 e assim por diante, sendo o próximo número a soma do último número com o seu anterior.
*/


using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Teste2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool verified = false;
            string input = string.Empty;
            int firstNum = 1;
            int secondNum = 1;
            List<int> output = new List<int>();
            while (!verified) {
                Console.WriteLine("Digite um número entre 1 e 19: ");
                input = Console.ReadLine();
                verified = CheckRequirements(input);
            }


            int num = Convert.ToInt32(input);
            for (int i = 0; i < num; i++) {
                if (i == 0 || i == 1)
                    output.Add(firstNum);
                else {
                    int next = firstNum + secondNum;
                    firstNum = secondNum;
                    secondNum = next;
                    output.Add(next);
                }
            }

            Console.WriteLine($"Saída: {string.Join(",", output)}");
        }

        private static bool CheckRequirements(string input)
        {
            int num;
            return int.TryParse(input, out num) && num > 0 && num < 20;
        }
    }
}