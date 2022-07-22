namespace TestProjectForNxDotNetIssue;

public class Class1
{
    public string hello()
    {
        return "hello";
    }

    public static string operator +(Class1 a, Class1 b)
      => a.hello() + " " + b.hello();
}
