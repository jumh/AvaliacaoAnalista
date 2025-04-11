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
            var text = "";
            do
            {
                Console.Clear();

                Console.WriteLine("Informe o texto:");
                text = Console.ReadLine();
                text = text.Trim();

                if (text.Length == 0)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Você precisa informa um texto");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Aperte qualquer tecla para tentar novamente");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                }
                else
                    CleanDuplicates(text);

            } while (text.Length == 0);
        }

        static void CleanDuplicates(string text)
        {
            char last = text[0];
            var newText = last.ToString();

            for (int i = 1; i < text.Length; i++)
            {
                if (text[i] != last)
                {
                    newText += text[i];
                    last = text[i];
                }
            }

            Console.WriteLine("Texto modificado:");
            Console.WriteLine(newText);
            Console.WriteLine("");
            Console.WriteLine($"{text.Length - newText.Length} caracteres removidos.");
            Console.WriteLine("");
            ShowOptions();
        }

        static void ShowOptions()
        {
            Console.WriteLine("Precione 1 para repetir ou 2 para sair");
            var key = Console.ReadKey().KeyChar.ToString();

            switch (key)
            {
                case "1":
                    Main(args: []);
                    break;
                case "2":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    ShowOptions();
                    break;
            }

        }
    }
}