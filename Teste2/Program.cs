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
            Console.WriteLine("Insira um número para geração da sequência de Fibonacci (entre 1 e 20)");
            try
            {
                var numeroDeRepeticoes = int.Parse(Console.ReadLine());
                
                Console.WriteLine(GerarSequenciaDeFibonacci(numeroDeRepeticoes));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Valor inválido");
            }
        }

        public static string GerarSequenciaDeFibonacci(int numeroDeRepeticoes)
        {
            if (numeroDeRepeticoes < 1 || numeroDeRepeticoes > 20)
                return "É necessário informar um número entre 1 e 20";
            
            var resultado = new List<int>();
            var contador = 1;
            while (contador <= numeroDeRepeticoes)
            {
                if(contador <= 2)
                    resultado.Add(1);
                else 
                    resultado.Add(resultado[contador - 2] + resultado[contador - 3]);   
                
                contador++;
            }   
            
            return string.Join(",", resultado);
        }
    }
}