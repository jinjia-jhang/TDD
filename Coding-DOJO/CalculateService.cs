namespace Coding_DOJO;

public class CalculateService
{
    public string ReplaceNumber(int number)
    {
        
        if ((number % 3 == 0 || number.ToString().Contains("3")) &&
            (number % 5 == 0 || number.ToString().Contains("5")) &&
            (number % 7 == 0 || number.ToString().Contains("7")))
        {
           return "FizzBuzzWhizz";
        }
        
        if ((number % 3 == 0 && number % 5 == 0) || (number.ToString().Contains("3") && number.ToString().Contains("5"))) return "FizzBuzz";
        if ((number % 3 == 0 || number.ToString().Contains("3")) && (number % 7 == 0 || number.ToString().Contains("7"))) 
            return "FizzWhizz";
        if (number % 3 == 0 || number.ToString().Contains("3")) return "Fizz";
        if (number % 5 == 0 || number.ToString().Contains("5")) return "Buzz";
        if (number % 7 == 0 || number.ToString().Contains("7")) return "Whizz";    
        
        return number.ToString();
    }
}