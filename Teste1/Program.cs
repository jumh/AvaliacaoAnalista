/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite uma string alfanumérica.
    2 - A aplicação deve remover todos os valores duplicados próximos, de forma que não hajam letras/números iguais juntos.
    Exemplo: AAABCCDDD -> Retorno : ABCD
 */

using System;

namespace Teste1 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Digite uma string alfanumérica: ");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input)) {
                Console.WriteLine("Entrada inválida.");
                return;
            }

            string resultado = RemoverDuplicadosProximos(input);
            Console.WriteLine($"Resultado: {resultado}");
        }

        static string RemoverDuplicadosProximos(string texto) {
            if (string.IsNullOrEmpty(texto)) return texto;

            char anterior = texto[0];
            string resultado = anterior.ToString();

            for (int i = 1; i < texto.Length; i++) {
                if (texto[i] != anterior) {
                    resultado += texto[i];
                    anterior = texto[i];
                }
            }

            return resultado;
        }
    }
}