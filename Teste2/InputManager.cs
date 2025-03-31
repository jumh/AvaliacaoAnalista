public class InputManager
{
    public static int GetValidUserInput()
    {
        Console.WriteLine("Digite um número inteiro positivo entre 1 e 19: ");
        while(true)
        {
            var userInput = Console.ReadLine();
            if (int.TryParse(userInput, out int userInputToNumber) && userInputToNumber > 0 && userInputToNumber < 20)
                return userInputToNumber;

            Console.WriteLine("Entrada inválida ou vazia. Digite um número inteiro entre 1 e 19.");
        }
    }
}