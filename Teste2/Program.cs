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
            Console.WriteLine("Digite um número: ");
            var ehInteiro = Int32.TryParse(Console.ReadLine(), out var numero);

            if (numero <= 0 || numero >= 20 || !ehInteiro)
            {
                Console.WriteLine("Digite um número inteiro, positivo, maior que 0 e menor que 20.");
                return;
            }
            
            for (int i = 1; i < numero; i++)
            {
                Console.Write($"{GetFibonacci(i)},");
            }
            // pra deixar mais organizado
            Console.WriteLine($"{GetFibonacci(numero)}");

        }

        static int GetFibonacci(int numero)
        {
            if (numero <= 1)
                return numero;
            return GetFibonacci(numero - 1) + GetFibonacci(numero - 2);
        }
    }
}