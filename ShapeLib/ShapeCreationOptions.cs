namespace ShapeLib;

public struct ShapeCreationOptions
{
	public required ShapeType Type { get; set; }
	public List<double> Sides { get; set; }
	public double Radius { get; set; }

	public List<double> GetSides(int numSides)
	{
		if (Sides == null)
		{
			Sides = Enumerable.Repeat<double>(0, numSides).ToList();
			return Sides;
		}

		if (numSides <= Sides.Count)
		{
			return Sides;
		}

		for (int i = 0; i < numSides - Sides.Count; i++)
		{
			Sides.Add(0);
		}

		return Sides;
	}
}
