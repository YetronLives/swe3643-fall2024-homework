using homework;

namespace Tests;

public class Tests
{
    // [SetUp]
    // public void Setup()
    // {
    // }

    [Test]
    public void PassingTest()
    {
        // Assert.AreEqual(4, Calculator.Add(2,2));
        Assert.That(Calculator.Add(2,2), Is.EqualTo(4));
    }
    
    [Test]
    public void FailingTest()
    {
        Assert.AreEqual(4, Calculator.Add(2,2));
    }
}