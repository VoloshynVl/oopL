// Інтерфейс IShape
public interface IShape
{
    void DisplayType();
    void DisplayArea();
    double FirstDimension { get; set; }
}

// Інтерфейс IColoredShape успадковується від IShape
public interface IColoredShape : IShape
{
    string Color { get; set; }
    void DisplayColor();
}

// Клас Circle реалізує інтерфейс IShape
public class Circle : IShape
{
    public double FirstDimension { get; set; }

    public void DisplayType()
    {
        Console.WriteLine("Figure Type: Circle");
    }

    public void DisplayArea()
    {
        double area = Math.PI * Math.Pow(FirstDimension, 2);
        Console.WriteLine($"Area: {area}");
    }
}

// Клас ColoredCircle реалізує інтерфейс IColoredShape
public class ColoredCircle : IColoredShape
{
    public double FirstDimension { get; set; }
    public string Color { get; set; }

    public void DisplayType()
    {
        Console.WriteLine("Figure Type: Colored Circle");
    }

    public void DisplayArea()
    {
        double area = Math.PI * Math.Pow(FirstDimension, 2);
        Console.WriteLine($"Area: {area}");
    }

    public void DisplayColor()
    {
        Console.WriteLine($"Color: {Color}");
    }
}
