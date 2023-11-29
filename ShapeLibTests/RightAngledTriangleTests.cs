namespace ShapeLibTests;

public class RightAngledTriangleTests
{
    [Test]
    public void TestRightAngledTriangleArea()
    {
        var t = new RightAngledTriangle(3, 4, 5);

        var expected = 6;
        var actual = t.Area();

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void TestInvalidRightAngledTriangle()
    {
        Assert.Throws<Exception>(() => new RightAngledTriangle(1, 1, 1));
    }
}

