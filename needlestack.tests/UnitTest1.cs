namespace needlestack.tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        string stack = "needlestack";
        string needle = "needle";

        int result = core.Class1.NeedleStack(stack, needle);

        Assert.Equal(0, result);
    }

    [Fact]
    public void Test2()
    {
            string stack = "stackneedle";
        string needle = "needle";

        int result = core.Class1.NeedleStack(stack, needle);

        Assert.Equal(5, result);
    }

    [Fact]
    public void Test3()
    {
        string stack = "leetcode";
        string needle = "leeto";

        int result = core.Class1.NeedleStack(stack, needle);

        Assert.Equal(-1, result);
    }
}
