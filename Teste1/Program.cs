/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite uma string alfanumérica.
    2 - A aplicação deve remover todos os valores duplicados próximos, de forma que não hajam letras/números iguais juntos.
    Exemplo: AAABCCDDD -> Retorno : ABCD
 */

using System;

namespace Teste1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma palavra (letras/numeros)");
            string? palavraDigitada = Console.ReadLine();

            if (!ValidarPalavraDigitada(palavraDigitada)) return;

            string palavraSemDuplicidade = RemoverCaracteresDuplicadaos(palavraDigitada);

            Console.WriteLine($"Palavra sem repetições: {palavraSemDuplicidade}");
        }

        static string RemoverCaracteresDuplicadaos(string palavra)
        {
            string palavraSemDuplicidade = palavra[0].ToString();   //Inicializando variável para iteração 

            for (int c = 1; c < palavra.Count(); c++)
            {
                var letraAtual = palavra[c];
                var letraAnterior = palavraSemDuplicidade[palavraSemDuplicidade.Count() - 1];

                if(letraAnterior != letraAtual)
                    palavraSemDuplicidade += letraAtual;    
            }

            return palavraSemDuplicidade;
        }

        static bool ValidarPalavraDigitada(string? palavra)
        {
            if (String.IsNullOrEmpty(palavra.Trim()))
            {
                Console.WriteLine("Palavra não iniciada");
                return false;
            }

            return true;
        }
    }
}