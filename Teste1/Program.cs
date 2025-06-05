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
            Console.WriteLine("Digite um texto alfanumérico:");

            var response = Console.ReadLine();

            var letraAnterior = string.Empty;
            var textoLimpo = string.Empty;
            for(var i = 0; i < response.Count(); i++)
            {
                if (response[i].ToString() != letraAnterior)
                    textoLimpo += response[i].ToString();

                letraAnterior = response[i].ToString();
            }

            Console.WriteLine(textoLimpo);
        }
    }
}