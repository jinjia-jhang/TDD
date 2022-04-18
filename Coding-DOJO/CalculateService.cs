namespace Coding_DOJO;

public class CalculateService
{
    public string ReplaceNumber(int number)
    {
        if (ContainsAndDivide(number, 3) && ContainsAndDivide(number, 5) && ContainsAndDivide(number, 7))
           return "FizzBuzzWhizz";
        
        if (IsDevideNumber(number, 3) && IsDevideNumber(number, 5) || IsContainsNumber(number, 3) && IsContainsNumber(number, 5)) return "FizzBuzz";
        if (ContainsAndDivide(number, 3)  && ContainsAndDivide(number, 7)) 
            return "FizzWhizz";
        
        if (ContainsAndDivide(number, 3)) return "Fizz";
        if (ContainsAndDivide(number, 5)) return "Buzz";
        if (ContainsAndDivide(number, 7)) return "Whizz";    
        
        return number.ToString();
    }

    private static bool ContainsAndDivide(int number, int divisionNum)
    {
        return IsDevideNumber(number, divisionNum) || IsContainsNumber(number, divisionNum);
    }

    private static bool IsContainsNumber(int number, int containsNum)
    {
        return number.ToString().Contains(containsNum.ToString());
    }

    private static bool IsDevideNumber(int number, int divisionNum)
    {
        return number % divisionNum == 0;
    }
}