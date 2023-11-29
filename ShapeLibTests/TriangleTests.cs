namespace ShapeLibTests;

public class TriangleTests
{
	[Test]
	public void TestTriangleArea()
	{
		var t = new Triangle(3, 4, 5);

		var expected = 6;
		var actual = t.Area();

		Assert.That(actual, Is.EqualTo(expected));
        Assert.That(t.IsRightAngled, Is.EqualTo(true));
	}

    [Test]
    public void TestEqualTriangleArea()
    {
        var t = new Triangle(1, 1, 1);

        var expected = 0.433;
        var actual = t.Area();

        Assert.That(actual, Is.EqualTo(expected).Within(0.01));
        Assert.That(t.IsRightAngled, Is.EqualTo(false));
    }

    [Test]
    public void TestInvalidTriangle()
    {
        Assert.Throws<Exception>(() => new Triangle(1, 2, 3));
    }
}

