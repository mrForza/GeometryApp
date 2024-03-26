using GeometryLibrary.Validators;

namespace GeometryLibrary.Figures;

public class Circle : Figure
{
    private readonly double _radius;

    private readonly string _name;
    
    public sealed override double Perimeter { get; init; }
    
    public sealed override double Square { get; init; }
    
    protected sealed override double _calculatePerimeter()
    {
        return Math.Round(2 * Math.PI * _radius, 8);
    }

    protected sealed override double _calculateSquare()
    {
        return Math.Round(Math.PI * Math.Pow(_radius, 2), 8);
    }

    public Circle(string name, double radius)
    {
        CircleValidator.ValidateRadius(radius);
        
        _name = name;
        _radius = radius;

        Perimeter = _calculatePerimeter();
        Square = _calculateSquare();
    }

    public override string ToString()
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        return "\n" + $"""
                Circle {_name} with radius: {_radius}
                Perimeter: {Perimeter}
                Square: {Square}
                """;
    }
}