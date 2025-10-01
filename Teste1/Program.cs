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
            string input = "";

            while (string.IsNullOrWhiteSpace(input))
            {
                Console.Write("Digite um conjunto de letras e números: ");
                input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Digite algo!");
                }
            }

            string resultado = RemoverDuplicadosConsecutivos(input.ToUpper()); // o ToUpper aqui faz com que aAa -> A, mas não sabia pelos requisitos se deveria ser case sensitive ou não, depende se definirmos que um A e a são letras iguais ou diferentes.

            Console.WriteLine($"Resultado: {resultado}");
        }

        static string RemoverDuplicadosConsecutivos(string str)
        {
            if (string.IsNullOrEmpty(str)) return str;

            char[] chars = str.ToCharArray();
            string resultado = chars[0].ToString(); 

            for (int i = 1; i < chars.Length; i++)
            {
                if (chars[i] != chars[i - 1])
                {
                    resultado += chars[i];
                }
            }

            return resultado;
        }
    }
}