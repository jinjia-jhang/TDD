using System.Collections;
using System.Collections.Generic;
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
    public void ReplaceNumber_input3_Fizz()
    {
        var number = 3;
        var actual = _calculateService.ReplaceNumber(number);

        Assert.AreEqual("Fizz", actual);
    }
    [Test]
    public void ReplaceNumber_input5_Buzz()
    {
        var number = 5;
        var actual = _calculateService.ReplaceNumber(number);

        Assert.AreEqual("Buzz", actual);
    }
    [Test]
    public void ReplaceNumber_input15_FizzBuzz()
    {
        var number = 15;
        var actual = _calculateService.ReplaceNumber(number);

        Assert.AreEqual("FizzBuzz", actual);
    }
    
    [Test]
    public void ReplaceNumber_input2_2()
    {
        var number = 2;
        var actual = _calculateService.ReplaceNumber(number);

        Assert.AreEqual("2", actual);
    }
    
    [Test]
    public void ReplaceNumber_input13_Fizz()
    {
        var number = 13;
        var actual = _calculateService.ReplaceNumber(number);

        Assert.AreEqual("Fizz", actual);
    }
    
    [Test]
    public void ReplaceNumber_input52_Buzz()
    {
        var number = 52;
        var actual = _calculateService.ReplaceNumber(number);

        Assert.AreEqual("Buzz", actual);
    }
    
    [Test]
    public void ReplaceNumber_input35_FizzBuzzWhizz()
    {
        var number = 35;
        var actual = _calculateService.ReplaceNumber(number);

        Assert.AreEqual("FizzBuzzWhizz", actual);
    }
    
    [Test]
    public void ReplaceNumber_input53_FizzBuzz()
    {
        var number = 53;
        var actual = _calculateService.ReplaceNumber(number);

        Assert.AreEqual("FizzBuzz", actual);
    }
    
    [Test]
    public void ReplaceNumber_input7_Whizz()
    {
        var number = 7;
        var actual = _calculateService.ReplaceNumber(number);

        Assert.AreEqual("Whizz", actual);
    }
    
    [Test]
    public void ReplaceNumber_input17_Whizz()
    {
        var number = 17;
        var actual = _calculateService.ReplaceNumber(number);

        Assert.AreEqual("Whizz", actual);
    }
    
    [Test]
    public void ReplaceNumber_input21_FizzWhizz()
    {
        var number = 21;
        var actual = _calculateService.ReplaceNumber(number);
        
        Assert.AreEqual("FizzWhizz", actual);
    }
    
    [Test]
    public void ReplaceNumber_useConfigurationInput4_Gozz()
    {
        var configuration = new Dictionary<int, string>()
        {
            {4, "Gozz"},
            {6, "Rozz"}
        };
        var number = 4;
        
        var service = new CalculateService(configuration);
        var actual = service.ReplaceNumber(4);
        
        Assert.AreEqual("Gozz", actual);
    }
    
    [Test]
    public void ReplaceNumber_useConfigurationInput5_5()
    {
        var configuration = new Dictionary<int, string>()
        {
            {4, "Gozz"},
            {6, "Rozz"}
        };
        var number = 5;
        
        var service = new CalculateService(configuration);
        var actual = service.ReplaceNumber(number);
        
        Assert.AreEqual("5", actual);
    }
    
    [Test]
    public void ReplaceNumber_useConfigurationInput12_GozzRozz()
    {
        var configuration = new Dictionary<int, string>()
        {
            {4, "Gozz"},
            {6, "Rozz"}
        };
        var number = 12;
        
        var service = new CalculateService(configuration);
        var actual = service.ReplaceNumber(number);
        
        Assert.AreEqual("GozzRozz", actual);
    }
    
}