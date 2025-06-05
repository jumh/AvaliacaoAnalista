/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite uma string alfanumérica.
    2 - A aplicação deve remover todos os valores duplicados próximos, de forma que não hajam letras/números iguais juntos.
    Exemplo: AAABCCDDD -> Retorno : ABCD
 */

using System.Reflection.Metadata;

namespace Teste1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool encerrarTeste = false;

            Console.WriteLine("Bem vindo ao Teste1");

            while (!encerrarTeste)
            {
                //Teste
                IniciarTesteCaracteresDuplicados();

                //Redundancia para repetir o teste
                Console.WriteLine("Deseja repetir o teste? (S/N)");
                string resposta = (Console.ReadLine() ?? string.Empty).Trim().ToLower();
                if (resposta == "n" || resposta == "nao")
                    encerrarTeste = true;
            }

            Console.WriteLine("Obrigado por ter feito meu teste ;)");
            Console.ReadKey();
        }

        static bool ValidarTextoAlfaNumerico(string texto)
        {
            foreach (char c in texto)
            {
                if (!char.IsLetter(c) && !char.IsDigit(c) && c != ','&& c != '\u00A0' && c!= '´')
                    return false;
            }

            return true;
        }


        /// <summary>
        /// Lógica do Teste1: Teste de Caracteres duplicados em sequencia
        /// </summary>
        static void IniciarTesteCaracteresDuplicados()
        {
            Console.WriteLine("Digite uma palavra ou número para limpar caracteres repetidos:");

            string valorDigitado = Console.ReadLine() ?? string.Empty;
            bool validadorAlfaNumerico = ValidarTextoAlfaNumerico(valorDigitado);

            if (validadorAlfaNumerico)
            {
                string valorConvertido = RetornaCaracteresTratados(valorDigitado);
                Console.WriteLine($"Seu resultado limpo de caracteres repetidos: {valorConvertido}");
            }
            else
            {
                Console.WriteLine($"O texto({valorDigitado}) não é um texto alfanumérico!");
                Console.WriteLine("Digite (I) para saber oque é um texto alfanumérico ou digite (C) para continuar.");
                string acaoPosValidacao = Console.ReadLine() ?? string.Empty;

                if (!acaoPosValidacao.Trim().Equals("c"))
                {
                    Console.WriteLine("Textos Alfanuméricos são textos que tem apenas letras [A-Z] ou numeros [0-9], esse texto não deve contes simbolos ou caracteres especiais (@, Espaço, Virgula);");
                    Console.WriteLine("Aperte Enter para continuar");
                    Console.ReadKey();
                }

                Console.Clear();
                IniciarTesteCaracteresDuplicados();
            }

        }


        /// <summary>
        /// Método que trata qualquer valor sem caracteres repetidos (AABBCC) -> ABC
        /// </summary>
        /// <param name="valorInicial"></param>
        /// <returns></returns>
        static string RetornaCaracteresTratados(string valorInicial)
        {
            string valorTratado = "";

            for (var x = 0; x < valorInicial.Length; x++)
            {
                if (x == 0 //-> se a posição for incial
                   || valorInicial[x] != valorInicial[x - 1] //-> se for a letra anterior
                  )
                {
                    valorTratado += valorInicial[x];
                }
            }

            return valorTratado;
        }
    }
}