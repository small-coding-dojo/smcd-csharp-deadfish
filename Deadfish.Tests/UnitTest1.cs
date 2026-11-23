using System.Reflection;

namespace Deadfish.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var actual = Deadfish.Parse("io");
        var expected = new int[]{1};
        Assert.Equals(actual, expected, "because incremented once");
    }
}
