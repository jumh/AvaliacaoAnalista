/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite uma string alfanumérica.
    2 - A aplicação deve remover todos os valores duplicados próximos, de forma que não hajam letras/números iguais juntos.
    Exemplo: AAABCCDDD -> Retorno : ABCD
 */
using System;

namespace Teste1
{
    internal class Program
    {

        static void Main(string[] args)
        {
           
            Console.WriteLine("Por favor, digite uma palavra no qual pode contar com letras e/ou números.\nApós isso, clique na tecla 'Enter' para confirmar:");
            
            string? txt1 = Console.ReadLine();
            // caso a string txt1 for nulo ou esteja vazia, então retorna a mensagem de erro
            if (string.IsNullOrEmpty(txt1))
            {
                    Console.WriteLine("Desculpe, não foi encontrado nenhum valor digitado. Por favor tente novamente.");
                    return;  
            }
            
            // Para cada carecter c encontrado em txt1
            foreach (char x in txt1)
                {
                    // caso qualquer caractere da palavra não for digito ou numero, então retorna a mensagem de erro
                    if (!char.IsLetterOrDigit(x))
                    {
                        Console.WriteLine("Os palavra informada devem conter somente letras e/ou numeros, sem a presença de caracteres especiais, pontuações e/ou espaço(s). Por favor tente novamente");
                        return;
                    }

                }

            string resultado_final = RemoveDuplicados(txt1);
            Console.WriteLine($"Resultado final: {resultado_final}");

        }


        private static string RemoveDuplicados(string x)
        {
            string resultado = x[0].ToString();

            // for para percorrer a palavra por completo
            for (int i = 1; i < x.Length; i++)
            {
                // caso o valor do caracter atual for diferente do anterior. Então inclui o caracter em questão na variavel resultado
                if (x[i] != x[i - 1])
                {
                    resultado += x[i];
                }
            }

            return resultado;

        }

    }
}

/* Pontos onde nos requisitos não ficaram muito claros e poderiam ser futuras melhorias (conversar com o solicitante):
    1 - Não é informado se o sistema deve deixar o usuário refazer automaticamente caso houver algum erro por parte do mesmo.
    2 - Não é informado se "valores duplicados próximos" podem ser de natureza mainuscula e/ou minuscula.
        exemplo: AAaaBBccDd   
        resultado 1 (diferenciação entre maiuscula e minuscula) : AaBcDd
        resultado 2 (não diferenciação entre maiuscula e minuscula) : ABcD
*/