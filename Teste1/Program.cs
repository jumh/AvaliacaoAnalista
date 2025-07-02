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
            List<char> response = new List<char>();
            string stringAlfanumerica = string.Empty;

            Console.WriteLine("Entre com uma string alfanumérica: ");
            stringAlfanumerica = Console.ReadLine();

            // Console.WriteLine("O usuário digitou: " + stringAlfanumerica);

            response.Add(stringAlfanumerica[0]);

            for(int i = 1; i < stringAlfanumerica.Length; i++)
            {
                if(stringAlfanumerica[i] != stringAlfanumerica[i - 1])
                {
                    response.Add(stringAlfanumerica[i]);
                }
            }

            Console.WriteLine(response.ToArray());
            // Console.WriteLine("Boa sorte!");
        }
    }
}