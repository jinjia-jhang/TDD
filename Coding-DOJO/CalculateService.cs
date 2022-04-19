using System.Collections;

namespace Coding_DOJO;

public class CalculateService
{
    private readonly Dictionary<int, string> _configuration;
    
    public CalculateService()
    {
        _configuration = new Dictionary<int, string>()
        {
            {3, "Fizz"},
            {5, "Buzz"},
            {7, "Whizz"}
        };
    }
    
    public CalculateService(Dictionary<int,string> configuration)
    {
        _configuration = configuration;
    }

    public string ReplaceNumber(int number)
    {
        var str = string.Empty;
        foreach (var (keyNum, replaceStr) in _configuration)
        {
            if (ContainsAndDivide(number, keyNum))
            {
                str += replaceStr;
            }
        }

        if (str == string.Empty) str = number.ToString();
        
        return str;
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