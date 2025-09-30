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
            string digitado = "0";
            int repeticao = -1;

            // Aqui zero pra sair
            while (repeticao != 0)
            {
                Console.WriteLine("\nDigite um número maior que 0 e menor que 20, (zero pra sair):");
                digitado = Console.ReadLine();

                try
                {
                    repeticao = Convert.ToInt32(digitado);

                    if (repeticao > 0 && repeticao < 20)
                    {
                        Console.WriteLine("Beleza " + repeticao + " vezes");

                        int penultimo = 1;
                        int ultimo = 1;
                        int atual = 1;

                        Console.WriteLine("Na 1ª E 2ª repetição é 1");

                        for (int i = 0; i < repeticao - 2; i++)
                        {
                            atual = penultimo + ultimo;
                            penultimo = ultimo;
                            ultimo = atual;

                            Console.WriteLine("Na " + (i + 3) + "ª repetição é " + atual);
                        }

                        continue;
                    }

                    Console.WriteLine("Valor maior que zero e menor que 20!");
                }
                catch (Exception)
                {
                    Console.WriteLine("Por favor, digite corretamente!");
                }


            }

        }
    }
}