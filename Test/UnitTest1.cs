namespace HelloWorld;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Math()
    {
        int a = 2;
        int b = 3;
        int expected = 8;
        HelloWorld.Mathst mathst = new HelloWorld.Mathst();
        int actual = mathst.Mathstep(a, b);
        Assert.AreEqual(expected, actual);
    }
}
