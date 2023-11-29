namespace ShapeLibTests;

public class ShapeFactoryTests
{
	[Test]
	public void TestCreateCircle()
	{
		var options = new ShapeCreationOptions
		{
			Type = ShapeType.Circle,
			Radius = 3,
		};

		var shape = ShapeFactory.CreateShape(options);
		var expected = typeof(Circle);
		var actual = shape.GetType();

		Assert.That(actual, Is.EqualTo(expected));
	}

    [Test]
    public void TestCreateTriangle()
    {
        var options = new ShapeCreationOptions
        {
            Type = ShapeType.Triangle,
            Sides = new List<double> { 3, 3, 5},
        };

        var shape = ShapeFactory.CreateShape(options);
        var expected = typeof(Triangle);
        var actual = shape.GetType();

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void TestCreateRightTriangle()
    {
        var options = new ShapeCreationOptions
        {
            Type = ShapeType.Triangle,
            Sides = new List<double> { 3, 4, 5 },
        };

        var shape = ShapeFactory.CreateShape(options);
        var expected = typeof(RightAngledTriangle);
        var actual = shape.GetType();

        Assert.That(actual, Is.EqualTo(expected));
    }
}

