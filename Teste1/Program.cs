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
            while (true)
            {
                Console.Write("Digite uma string alfanumérica: ");
                string palavraUsuario = Console.ReadLine();
                if (palavraUsuario.All(char.IsLetterOrDigit) && !String.IsNullOrWhiteSpace(palavraUsuario))
                    Console.WriteLine("Palavra atualizada: {0}", RemoverCaracteresDuplicadosConsecutivos(palavraUsuario));
                else Console.WriteLine("String inválida");
                Console.WriteLine();
            }
        }

        public static StringBuilder RemoverCaracteresDuplicadosConsecutivos(string palavra)
        {
            StringBuilder palavraAtualizada = new StringBuilder();
            int aux = 1;

            for (int i = 0; i < palavra.Length; i++)
            {
                if (i == 0) palavraAtualizada.Append(palavra[i]);
                else
                {
                    if (palavraAtualizada[i - aux] == palavra[i])
                    {
                        aux++;
                        continue;
                    }
                    palavraAtualizada.Append(palavra[i]);
                }
            }

            return palavraAtualizada;
        }
    }
}