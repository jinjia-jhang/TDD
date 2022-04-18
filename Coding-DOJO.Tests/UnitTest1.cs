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
}