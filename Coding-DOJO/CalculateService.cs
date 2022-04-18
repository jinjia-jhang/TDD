namespace Coding_DOJO;

public class CalculateService
{
    public string ReplaceNumber(int number)
    {
        if (ContainsAndDivide_3(number) && ContainsAndDivide_5(number) && ContainsAndDivide_7(number))
            return "FizzBuzzWhizz";
        
        if ((number % 3 == 0 && number % 5 == 0) || (number.ToString().Contains("3") && number.ToString().Contains("5"))) 
            return "FizzBuzz";
        
        if (ContainsAndDivide_3(number)  && (number % 7 == 0 || number.ToString().Contains("7"))) 
            return "FizzWhizz";
        
        if (ContainsAndDivide_3(number)) return "Fizz";
        if (ContainsAndDivide_5(number) ) return "Buzz";
        if (ContainsAndDivide_7(number)) return "Whizz";    
        
        return number.ToString();
    }

    private static bool ContainsAndDivide_7(int number)
    {
        return number % 7 == 0 || number.ToString().Contains("7");
    }

    private static bool ContainsAndDivide_5(int number)
    {
        return (number % 5 == 0 || number.ToString().Contains("5"));
    }

    private static bool ContainsAndDivide_3(int number)
    {
        return number % 3 == 0 || number.ToString().Contains("3");
    }
}