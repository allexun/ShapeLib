namespace ShapeLib;

public class Triangle : IShape, IShapeValidator
{
    public readonly double A;
    public readonly double B;
    public readonly double C;

    public Triangle(double a, double b, double c)
	{
        A = a;
        B = b;
        C = c;

        if (!IsValidShape)
        {
            throw new Exception("ivalid triangle");
        }
	}

    public virtual double Area()
    {
        var p = (A + B + C) / 2;
        return Math.Pow(p * (p - A) * (p - B) * (p - C), 0.5);
    }

    public bool IsRightAngled
    {
        get
        {
            var (a, b, c) = GetSortedSides();
            return Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2);
        }
    }

    public bool IsValidShape
    {
        get
        {
            return A + B > C &&
                B + C > A &&
                A + C > B;
        }
    }

    protected (double a, double b, double c) GetSortedSides()
    {
        var tempArr = new[] { A, B, C };
        Array.Sort(tempArr);
        var a = tempArr[0];
        var b = tempArr[1];
        var c = tempArr[2];

        return (a, b, c);
    }
}

