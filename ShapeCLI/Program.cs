using ShapeLib;

namespace ShapeCLI;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter shape type (circle, triangle):");

        var input = Console.ReadLine();

        var shape = TryCreateShape(input);
        if (shape == null)
        {
            Console.WriteLine("Unknown or invalid shape");
            return;
        }

        Console.WriteLine($"Area of the shape: {shape.Area()}");
    }

    private static IShape? TryCreateShape(string? input)
    {
        try
        {
            return input switch
            {
                "circle" => CreateCircle(),
                "triangle" => CreateTriangle(),
                _ => null,
            };
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Invalid shape: {ex.Message}");
            return null;
        }
    }

    private static IShape? CreateCircle()
    {
        Console.WriteLine("Enter circle radius:");
        var rStr = Console.ReadLine();
        if (!double.TryParse(rStr, out var r))
        {
            Console.WriteLine("Invalid radius");
            return null;
        }

        return ShapeFactory.CreateShape(new ShapeCreationOptions
        {
            Type = ShapeType.Circle,
            Radius = r,
        });
    }

    private static IShape? CreateTriangle()
    {
        Console.WriteLine("Enter triangle sides in format 'a b c':");
        var sidesStr = Console.ReadLine();
        var tokens = sidesStr?.Split(' ');
        if (tokens?.Length != 3)
        {
            Console.WriteLine("Should be exactly 3 sides");
            return null;
        }

        var sides = new List<double>();
        foreach (var t in tokens)
        {
            if (!double.TryParse(t, out var s))
            {
                Console.WriteLine("invalid number");
                return null;
            }

            sides.Add(s);
        }

        return ShapeFactory.CreateShape(new ShapeCreationOptions
        {
            Type = ShapeType.Triangle,
            Sides = sides,
        });
    }
}

