namespace Coding_DOJO;

public class CalculateService
{
    public string ReplaceNumber(int number)
    {
        if (number % 3 == 0) return "Fizz";
        if (number % 5 == 0) return "Buzz";
        
        return number.ToString();
    }
}