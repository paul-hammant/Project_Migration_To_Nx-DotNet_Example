using NUnit.Framework;

namespace TestProjectForNxDotNetIssue;

public class Tests2
{
  [Test]
    public void Test1()
    {
      var class1 = new Class1();
      Assert.AreEqual("hello hello", class1 + class1);
    }
}
