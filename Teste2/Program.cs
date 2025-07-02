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
            int aux = 1;
            int lastDigit = 1;
            int lastDigitAux = 0;
            int number = 0;

            Console.WriteLine("Entre com um número inteiro: ");
            try
            {
                number = int.Parse(Console.ReadLine());
            } catch(FormatException ex)
            {
                Console.WriteLine("Digite apenas números");
                Console.WriteLine(ex.Message);
            }

            if (!(number > 0) || !(number < 20))
            {
                Console.WriteLine("O número deve ser maior que 0 e menor que 20.");
                return;
            }

            for(int i = 0; i < (number -1); i++)
            {
                if(i == 0)
                {
                    Console.WriteLine(aux);
                    Console.WriteLine(lastDigit);
                } 
                else
                {

                    lastDigitAux = aux + lastDigit;
                    Console.WriteLine(lastDigitAux);
                    lastDigit = aux;
                    aux = lastDigitAux;
                }
            }

            // Console.WriteLine("Usuário digitou o número: " + number);
        }
    }
}