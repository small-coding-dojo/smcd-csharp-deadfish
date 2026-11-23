using System.Reflection;
using TheDeadfish = Deadfish.Logic.Deadfish;

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
        var actual = TheDeadfish.Parse("io");
        var expected = new int[]{1};
        Assert.That(actual, Is.EqualTo(expected), "because incremented once");
    }

    [Test]
    public void Test2()
    {
        var actual = TheDeadfish.Parse("iio");
        var expected = new int[]{2};
        Assert.That(actual, Is.EqualTo(expected), "because incremented once");
    }
}
