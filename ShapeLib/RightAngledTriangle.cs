namespace ShapeLib;

public class RightAngledTriangle : Triangle
{
	public RightAngledTriangle(double a, double b, double c): base(a, b, c)
	{
        if (!IsRightAngled)
        {
            throw new Exception("Not a valid right angled triangle");
        }
	}

    public override double Area()
    {
        var (a, b, _) = GetSortedSides();
        return 0.5 * a * b;
    }
}

