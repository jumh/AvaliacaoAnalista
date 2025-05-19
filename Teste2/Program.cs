/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite um número.
    2 - A aplicação deve ler essa entrada e garantir que foi digitado um número inteiro, positivo, maior que 0 e menor que 20.
    3 - A aplicação deve gerar uma sequência de Fibonacci com a quantidade de repetições informada pelo usuário.
    Obs: A seguência de Fibonacci segue o padrão 1,1,2,3,5,8 e assim por diante, sendo o próximo número a soma do último número com o seu anterior.
*/

using System;
using System.Collections.Generic;

namespace Teste2 {
    internal class Program {
        static void Main(string[] args) {
            int quantidade = 0;

            while (true) {
                Console.Write("Digite um número inteiro entre 1 e 19: ");
                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out quantidade) && quantidade > 0 && quantidade < 20) break;

                Console.WriteLine("O número digitado está inválido. Tente novamente.");
            }

            List<int> fibonacci = GerarFibonacci(quantidade);
            Console.WriteLine($"Sequência de Fibonacci com {quantidade} termo(s): {string.Join(", ", fibonacci)}");
        }

        static List<int> GerarFibonacci(int numeroRepeticoes) {
            List<int> sequencia = new List<int>();

            for (int i = 0; i < numeroRepeticoes; i++) {
                if (i == 0 || i == 1) sequencia.Add(1);
                else {
                    int proximo = sequencia[i - 1] + sequencia[i - 2];
                    sequencia.Add(proximo);
                }
            }

            return sequencia;
        }
    }
}