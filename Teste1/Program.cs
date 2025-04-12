/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite uma string alfanumérica.
    2 - A aplicação deve remover todos os valores duplicados próximos, de forma que não hajam letras/números iguais juntos.
    Exemplo: AAABCCDDD -> Retorno : ABCD
 */

using System.Text;

namespace Teste1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma string alfanumérica: ");
            var texto = Console.ReadLine();

            Console.WriteLine($"{texto} -> Retorno : {GetTextoSemDuplicadosProximosUsandoSet(texto)}");
        }


        // usando lógica
        static string GetTextoSemDuplicadosProximos(string? texto)
        {
            if (string.IsNullOrEmpty(texto))
                return string.Empty;

            StringBuilder textoSemDuplicados = new StringBuilder();
            
            char letraAnterior = char.MinValue;

            foreach (var letra in texto.ToList())
            {
                if (letra != letraAnterior)
                    textoSemDuplicados.Append(letra);
                letraAnterior = letra;
            }

            return textoSemDuplicados.ToString();
        }

        // usando Set
        static string GetTextoSemDuplicadosProximosUsandoSet(string? texto)
        {
            if (string.IsNullOrEmpty(texto))
                return string.Empty;

            HashSet<char> textoSemDuplicados = [.. texto.ToList()];

            return new string(textoSemDuplicados.ToArray());
        }
    }
}