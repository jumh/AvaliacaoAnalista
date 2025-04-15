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
            Console.Write("Informe um número : ");
			var numero = Console.ReadLine();

			if (!int.TryParse(numero, out var valor))
			{
				Console.WriteLine("O número deve ser inteiro");
			}
			else
			{
				if (valor < 1 || valor > 19)
				{
					Console.WriteLine("O número deve ser entre 1 e 19");
				}                
				else
				{
					int anterior = 0;
					int atual = 1;
					while (atual <= valor)
					{
						Console.Write(atual + " -->> ");
						int proximo = anterior + atual;
						anterior = atual;
						atual = proximo;
					}
				}
			}
        }
    }
}