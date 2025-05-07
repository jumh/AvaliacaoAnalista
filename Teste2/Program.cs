/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite um número.
    2 - A aplicação deve ler essa entrada e garantir que foi digitado um número inteiro, positivo, maior que 0 e menor que 20.
    3 - A aplicação deve gerar uma sequência de Fibonacci com a quantidade de repetições informada pelo usuário.
    Obs: A seguência de Fibonacci segue o padrão 1,1,2,3,5,8 e assim por diante, sendo o próximo número a soma do último número com o seu anterior.
*/

using System;
using System.Collections.Generic;

namespace Teste2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro positivo (maior que 0 e menor que 20)");
            string entrada = Console.ReadLine() ?? string.Empty;
            int quantidade;

            while (!int.TryParse(entrada, out quantidade) || quantidade <= 0 || quantidade >= 20)
            {
                Console.WriteLine("Entrada inválida. Digite um número inteiro maior que 0 e menor que 20");
                entrada = Console.ReadLine() ?? string.Empty;
            }

            List<int> sequencia = GerarFibonacci(quantidade);

            Console.WriteLine("\nSequência de Fibonacci:");
            Console.WriteLine(string.Join(", ", sequencia));

            Console.WriteLine("\nPressione qualquer tecla para sair");
            Console.ReadKey();
        }

        private static List<int> GerarFibonacci(int termos)
        {
            var resultado = new List<int>();
            if (termos >= 1)
                resultado.Add(1);
            if (termos >= 2)
                resultado.Add(1);

            for (int i = 2; i < termos; i++)
            {
                int proximo = resultado[i - 1] + resultado[i - 2];
                resultado.Add(proximo);
            }

            return resultado;
        }
    }
}

//A versão nova do .net não suporta mais alguns tipos de estruturas. Então tive que criar uma nova pasta nesse diretorio:
// C:\Program Files\dotnet\sdk -> NuGetFallbackFolder.
// Assim a aplicação funcionou.