using System;

namespace Teste1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma string alfanumérica: ");
            string entrada = Console.ReadLine();

            string resultado = remove_duplicatas(entrada);

            Console.WriteLine("Resultado: " + resultado);
        }

        static string remove_duplicatas(string texto)
        {
            if (string.IsNullOrEmpty(texto)) return "";

            char anterior = texto[0];
            string resultado = anterior.ToString();

            for (int i = 1; i < texto.Length; i++)
            {
                if (texto[i] != anterior)
                {
                    resultado += texto[i];
                    anterior = texto[i];
                }
            }

            return resultado;
        }
    }
}