using NUnit.Framework;

namespace Coding_DOJO.Tests;

public class Tests
{
    private CalculateService _calculateService;
    [SetUp]
    public void Setup()
    {
        _calculateService = new CalculateService();
    }

    [Test]
    public void methodsName_input3_Fizz()
    {
        var number = 3;
        var actual = _calculateService.ReplaceNumber(number);

        Assert.AreEqual("Fizz", actual);
    }
    [Test]
    public void methodsName_input5_Buzz()
    {
        var number = 5;
        var actual = _calculateService.ReplaceNumber(number);

        Assert.AreEqual("Buzz", actual);
    }
    [Test]
    public void methodsName_input15_FizzBuzz()
    {
        var number = 15;
        var actual = _calculateService.ReplaceNumber(number);

        Assert.AreEqual("FizzBuzz", actual);
    }
    
    [Test]
    public void methodsName_input2_2()
    {
        var number = 2;
        var actual = _calculateService.ReplaceNumber(number);

        Assert.AreEqual("2", actual);
    }
    
    [Test]
    public void methodsName_input13_Fizz()
    {
        var number = 13;
        var actual = _calculateService.ReplaceNumber(number);

        Assert.AreEqual("Fizz", actual);
    }
    
    [Test]
    public void methodsName_input52_Buzz()
    {
        var number = 52;
        var actual = _calculateService.ReplaceNumber(number);

        Assert.AreEqual("Buzz", actual);
    }
    
    [Test]
    public void methodsName_input35_FizzBuzz()
    {
        var number = 35;
        var actual = _calculateService.ReplaceNumber(number);

        Assert.AreEqual("FizzBuzz", actual);
    }
    
    [Test]
    public void methodsName_input53_FizzBuzz()
    {
        var number = 53;
        var actual = _calculateService.ReplaceNumber(number);

        Assert.AreEqual("FizzBuzz", actual);
    }
    
}