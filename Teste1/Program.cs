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
            Console.WriteLine("Boa sorte!");

            Console.Write("Digite um texto:");
            string entrada = Console.ReadLine();
            string output = new string(entrada.Distinct().ToArray());
            Console.WriteLine("Resultado: " + output);
            
            
        }
    }
}