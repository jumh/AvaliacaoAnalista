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
        public static void Main(string[] args)
        {
            Console.WriteLine("=== Removedor de Caracteres Duplicados Adjacentes ===");
            Console.WriteLine("Digite uma string alfanumérica (ex: AAABCCDDD):");

            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("A entrada não pode ser vazia.");
                return;
            }

            string resultado = RemoverDuplicatasAdjacentes(input.ToUpper());

            Console.WriteLine($"\nString Original: {input}");
            Console.WriteLine($"String Processada: {resultado}");

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }

    
        public static string RemoverDuplicatasAdjacentes(string str)
        {
            if (string.IsNullOrEmpty(str)) 
                return str;

            StringBuilder resultado = new StringBuilder();
            resultado.Append(str[0]);

            for (int i = 1; i < str.Length; i++)
            {
                char caractereAtual = str[i];
                char ultimoCaractereAdicionado = resultado[resultado.Length - 1];

                if (caractereAtual != ultimoCaractereAdicionado)
                    resultado.Append(caractereAtual);
            }

            return resultado.ToString();
        }
    }
}