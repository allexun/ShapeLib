namespace ShapeLibTests;

public class CircleTests
{
	[Test]
	public void TestCircleArea()
	{
		var circle = new Circle(5);

		var expexted = 78.54;
		var actual = circle.Area();

		Assert.That(actual, Is.EqualTo(expexted).Within(0.01));
	}

    [Test]
    public void TestInvalidCircle()
    {
		Assert.Throws<Exception>(() => new Circle(-5));
    }
}

