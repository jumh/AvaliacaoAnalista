/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite um número.
    2 - A aplicação deve ler essa entrada e garantir que foi digitado um número inteiro, positivo, maior que 0 e menor que 20.
    3 - A aplicação deve gerar uma sequência de Fibonacci com a quantidade de repetições informada pelo usuário.
    Obs: A seguência de Fibonacci segue o padrão 1,1,2,3,5,8 e assim por diante, sendo o próximo número a soma do último número com o seu anterior.
*/

namespace Teste2
{
    internal class Program
    {
         static void Main(string[] args)
        {
            // será reutilizada, com isso foi setada já como texto.
            string erro2 = "Por favor tente novamente, informando um numero valido conforme o enunciado.";
      
            // Título  e solicitação
            Console.WriteLine("------------------------ Sequencia de Fibonacci -------------------------");
            Console.WriteLine(" Por favor, digite a quantidade de valores gostaria de ver, entre 1 a 19 ");
            Console.WriteLine(" Após isso, clique na tecla 'Enter' para confirmar");

            string? num1 = Console.ReadLine();


            // caso a string num1 for nulo ou esteja vazia, então mostra a mensagem de erro
            if (string.IsNullOrEmpty(num1))
            {
                
                Console.WriteLine($"Não foi informado uma numeração.\n{erro2}");
                return;
            }

            // Percorre cada caracter digitado
            foreach(char x in num1)
            {
                // caso na string num1 tiver algum caracter diferente de digito de 0 a 9, então mostra a mensagem de erro
                if (!char.IsDigit(x))
                {
                    Console.WriteLine($"Não foi digitado valor numérico valido.\n{erro2}");
                    return;
                }
            }

            // Foi necessário transformar string em int (com o tryparse) para a verificação de caso o valor informado seja negativo, 0 ou maior que 20
            if (int.TryParse(num1, out int numero) && numero <= 0 || numero >= 20)
            {
                    Console.WriteLine($"Opção invalida.\n{erro2}");
            }
            else
            {
                Fibonacci(numero);
            }

        }    

            static void Fibonacci(int qtd)
        {
            // Como o valor inicial de Fibonacci, de acordo com o requisito sempre serão "1 1...", então foi setado como 1 o valor de "a" e "b"
            int a = 1;
            int b = 1;
            
            // Para a quantidade informada
            for (int i = 0; i < qtd; i++)
            {
                // mostrar valor sempre o valor de a    
                Console.Write(a + " ");

                // some o valor de: "a" + "b". 
                int proxnum = a + b;

                // atribua o valor de "b" em "a"
                a = b;
                
                // atribua o valor do "proxnum" em "b"
                b = proxnum;
            }

            Console.WriteLine(); // quebra de linha
        }
    }
}

 /* Possivel futura melhoria no qual não foi solicitado nos requisitos pedidos (conversar com o solicitante):
    1 - Não é informado se o sistema deve deixar o usuário refazer automaticamente caso houver algum erro por parte do mesmo.
 */