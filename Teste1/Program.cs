/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite uma string alfanumérica.
    2 - A aplicação deve remover todos os valores duplicados próximos, de forma que não hajam letras/números iguais juntos.
    Exemplo: AAABCCDDD -> Retorno : ABCD
 */

namespace Teste1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma string alfanumérica: ");
            string entrada = Console.ReadLine();

            string resultado = RemoverDuplicatasConsecutivas(entrada);

            Console.WriteLine($"\nResultado: {resultado}");
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }

        /// <summary>
        /// Remove caracteres duplicados consecutivos de uma string.
        /// </summary>
        /// <param name="entrada">String original</param>
        /// <returns>String sem duplicatas consecutivas</returns>
        static string RemoverDuplicatasConsecutivas(string entrada)
        {
            if (string.IsNullOrEmpty(entrada))
                return string.Empty;

            var resultado = entrada[0].ToString();

            for (int i = 1; i < entrada.Length; i++)
            {
                if (entrada[i] != entrada[i - 1])
                {
                    resultado += entrada[i];
                }
            }

            return resultado;
        }
    }
}