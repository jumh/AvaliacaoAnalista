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
            Console.WriteLine("Digite uma string alfanumérica (um texto):");
            string texto = Console.ReadLine();
            string novoTexto = "Resposta: ";

            for (int i = 0; i < texto.Length; i++)
            {
                // Aqui se for o último, só acata a letra e termina.
                if (i == texto.Length - 1)
                {
                    novoTexto += texto[i];
                    continue;
                }

                if (texto[i] != texto[i + 1]) novoTexto += texto[i];
            }

            Console.WriteLine(novoTexto);
            Console.ReadKey();
        }
    }
}