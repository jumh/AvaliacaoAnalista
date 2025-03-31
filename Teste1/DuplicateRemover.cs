using System.Text.RegularExpressions;

public class DuplicateRemover
{
    private readonly string RegexPattern = "([a-zA-Z0-9])\\1+";

    public string RemoveConsecutiveDuplicates(string userInput)
    {
        return Regex.Replace(userInput, RegexPattern, "$1");
    }
}