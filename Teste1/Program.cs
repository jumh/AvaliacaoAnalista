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
            string? input;

            while(true)
            {
                Console.WriteLine("Digite uma string alfanumérica:");

                input = Console.ReadLine();

                if (InputIsValid(input))
                {
                    break;
                }
            } 

            //uso stringbuilder por ser mais performático em operações de concatenação, uma vez que strings são imutáveis,
            // e toda vez que concateno uma string, uma nova instância é criada.
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input!.Length; i++)
            {
                var currentChar = input[i];

                //se for o primeiro elemento, não preciso validar duplicidade
                if (i is 0)
                {
                    sb.Append(currentChar);
                    continue;
                }

                //aqui eu posso obter o caractere anterior sem precisar validar, pois o índice 0 já foi tratado acima.
                var previousChar = input[i - 1];

                //agrupo apenas se for diferente do anterior
                if (currentChar != previousChar)
                {
                    sb.Append(currentChar);
                }
            }

            Console.WriteLine($"Resultado: {sb}");
        }

        static bool InputIsValid(string? input) {

            if(string.IsNullOrEmpty(input)){
                WriteErrorMessage();
                return false;
            }

            //checo se o input é alfanumérico
            foreach(char c in input){
                if(!char.IsLetterOrDigit(c)){
                    WriteErrorMessage();
                    return false;
                }
            }

            return true;
        }

        //escrevo a mensagem de erro em um método separado para evitar repetição de código
        static void WriteErrorMessage() => Console.WriteLine("Entrada inválida.");
    }
}