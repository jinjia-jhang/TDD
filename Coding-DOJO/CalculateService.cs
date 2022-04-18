namespace Coding_DOJO;

public class CalculateService
{
    public string ReplaceNumber(int number)
    {
        if (ContainsAndDivide_3(number) && ContainsAndDivide_5(number) && ContainsAndDivide_7(number))
        if (ContainsAndDivide_3(number) && ContainsAndDivide_5(number) && ContainsAndDivide_7(number))
           return "FizzBuzzWhizz";
        
        if ((number % 3 == 0 && number % 5 == 0) || (number.ToString().Contains("3") && number.ToString().Contains("5"))) return "FizzBuzz";
        if (ContainsAndDivide_3(number)  && (number % 7 == 0 || number.ToString().Contains("7"))) 
            return "FizzWhizz";
        if (ContainsAndDivide_3(number)) return "Fizz";
        if (ContainsAndDivide_5(number) ) return "Buzz";
        if (ContainsAndDivide_7(number)) return "Whizz";    
        
        return number.ToString();
    }

    private static bool ContainsAndDivide_7(int number)
    {
        var divisionNum = 7;
        return (IsDevideNumber(number, divisionNum) || number.ToString().Contains(divisionNum.ToString()));
    }

    private static bool ContainsAndDivide_5(int number)
    {
        var divisionNum = 5;
        return (IsDevideNumber(number, divisionNum) || number.ToString().Contains(divisionNum.ToString()));
    }

    private static bool ContainsAndDivide_3(int number)
    {
        var divisionNum = 3;
        return IsDevideNumber(number, divisionNum) || number.ToString().Contains(divisionNum.ToString());
    }

    private static bool IsDevideNumber(int number, int divisionNum)
    {
        return number % divisionNum == 0;
    }
}