using NUnit.Framework;

namespace Coding_DOJO.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void methodsName_input3_Fizz()
    {
        var number = 3;

        var actual = new CalculateService().ReplaceNumber(number);

        Assert.AreEqual("Fizz", actual);
    }
}