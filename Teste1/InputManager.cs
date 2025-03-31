using System.Text.RegularExpressions;

public class InputManager
{
    private readonly string RegexPattern = "^[a-zA-Z0-9]+$";

    public string? GetValidUserInput()
    {
        Console.WriteLine("Olá! Digite uma sequência de letras e números: ");
        while(true)
        {
            var userInput = Console.ReadLine();
            if(!string.IsNullOrEmpty(userInput) && Regex.IsMatch(userInput, RegexPattern))
                return userInput;

            Console.WriteLine("Entrada inválida ou vazia. Por favor, digite apenas letras e números: ");
        }
    }
}