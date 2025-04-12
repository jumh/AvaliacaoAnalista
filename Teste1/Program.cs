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
            Console.WriteLine("Digite uma cadeia de caracteres alfanuméricos ");
            var cadeiaDeCaracteres = Console.ReadLine();
            
            Console.WriteLine($"A equivalência da sua cadeia de caracteres sem incidir repetições: {RemoverCaracteresRepetidosSequencialmente(cadeiaDeCaracteres)}");
        }

        public static string RemoverCaracteresRepetidosSequencialmente(string cadeiaDeCaracteres)
        {
            cadeiaDeCaracteres = cadeiaDeCaracteres.Trim();
            if (String.IsNullOrEmpty(cadeiaDeCaracteres))
                return String.Empty;  
            
            var quantidadeDeCaracteres = cadeiaDeCaracteres.Length;
            var resultado = cadeiaDeCaracteres.FirstOrDefault().ToString();
            var indice = 1;
            
            while (indice < quantidadeDeCaracteres)
            {
                var caractereAtual = cadeiaDeCaracteres[indice];
                var caractereAnterior = cadeiaDeCaracteres[indice - 1];
                
                if(!caractereAtual.Equals(caractereAnterior))
                    resultado += caractereAtual;
                
                indice++;
            }
            
            return resultado;
        }
    }
}