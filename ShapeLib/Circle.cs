namespace ShapeLib;

public class Circle : IShape, IShapeValidator
{
    public readonly double Radius;

	public Circle(double radius)
	{
        Radius = radius;

        if (!IsValidShape)
        {
            throw new Exception("not a valid circle");
        }
	}

    public double Area()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }

    public bool IsValidShape
    {
        get => Radius > 0;
    }
}

