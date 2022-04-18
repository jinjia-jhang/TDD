namespace Coding_DOJO;

public class CalculateService
{
    public string ReplaceNumber(int number)
    {
        if ((number % 3 == 0 && number % 5 == 0) || (number.ToString().Contains("3") && number.ToString().Contains("5"))) return "FizzBuzz";
        if (number % 3 == 0 || number.ToString().Contains("3")) return "Fizz";
        if (number % 5 == 0 || number.ToString().Contains("5")) return "Buzz";
        
        return number.ToString();
    }
}