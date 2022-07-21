using NUnit.Framework;

namespace TestProjectForNxDotNetIssue;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.AreEqual("hello", new Class1().hello());
    }
}