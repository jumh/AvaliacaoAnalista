using Teste1;

namespace UnitTest;

public class Teste1
{
    [Fact]
    public void RemoveDuplicateLetters()
    {
        string input = "AAABCCDDD";
        string expected = "ABCD";

        string result = Program.RemoveDuplicateLetters(input);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void ReturnsSameSingleCharacter()
    {
        string input = "A";
        string expected = "A";

        string result = Program.RemoveDuplicateLetters(input);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void ReturnsEmptyString()
    {
        string input = "";
        string expected = "";

        string result = Program.RemoveDuplicateLetters(input);

        Assert.Equal(expected, result);
    }
    [Fact]
    public void ReturnsSameString()
    {
        string input = "ABC123";
        string expected = "ABC123";

        string result = Program.RemoveDuplicateLetters(input);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void CapitalLettersAreTreatedAsDifferentLetters()
    {
        string input = "aAaAaA";
        string expected = "aAaAaA";

        string result = Program.RemoveDuplicateLetters(input);

        Assert.Equal(expected, result);
    }
}
