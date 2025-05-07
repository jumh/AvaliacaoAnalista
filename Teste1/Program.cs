/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite uma string alfanumérica.
    2 - A aplicação deve remover todos os valores duplicados próximos, de forma que não hajam letras/números iguais juntos.
    Exemplo: AAABCCDDD -> Retorno : ABCD
 */

using System;
using System.Linq;
using System.Text;

namespace Teste1
{
    internal class Programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma string alfanumérica");
            string entrada = Console.ReadLine() ?? string.Empty;

           
            while (string.IsNullOrEmpty(entrada) || entrada.Any(c => !char.IsLetterOrDigit(c)))
            {
                Console.WriteLine("Digite apenas letras e numeros");
                entrada = Console.ReadLine() ?? string.Empty;
            }

            string resultado = RemoverDuplicadosAdjacentes(entrada);

            Console.WriteLine($"\nResultado: {resultado}");
            Console.WriteLine("Digite qualquer tecla para sair");
            Console.ReadKey(); 
        }

        private static string RemoverDuplicadosAdjacentes(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                return texto;

            var construtor = new StringBuilder();
            char ultimo = texto[0];
            construtor.Append(ultimo);

            for (int i = 1; i < texto.Length; i++)
            {
                if (texto[i] != ultimo)
                {
                    construtor.Append(texto[i]);
                    ultimo = texto[i];
                }
            }

            return construtor.ToString();
        }
    }
}
//A versão nova do .net não suporta mais alguns tipos de estruturas. Então tive que criar uma nova pasta nesse diretorio:
// C:\Program Files\dotnet\sdk -> NuGetFallbackFolder.
// Assim a aplicação funcionou.