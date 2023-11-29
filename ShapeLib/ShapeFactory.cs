namespace ShapeLib;

public static class ShapeFactory
{
	public static IShape CreateShape(ShapeCreationOptions options)
	{
		return options.Type switch
		{
			ShapeType.Circle => new Circle(options.Radius),
			ShapeType.Triangle => CreateTriangle(options),
			_ => throw new Exception(),
		};
	}

	private static Triangle CreateTriangle(ShapeCreationOptions options)
	{
		var sides = options.GetSides(3);
		var t = new Triangle(sides[0], sides[1], sides[2]);

		if (t.IsRightAngled)
		{
			return new RightAngledTriangle(t.A, t.B, t.C);
		}

		return t;
	}
}

