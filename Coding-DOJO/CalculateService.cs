namespace Coding_DOJO;

public class CalculateService
{
    public string ReplaceNumber(int number)
    {
        if (number % 3 == 0) return "Fizz";
        
        return number.ToString();
    }
}