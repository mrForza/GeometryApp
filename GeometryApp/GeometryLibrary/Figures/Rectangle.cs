using GeometryLibrary.Validators;

namespace GeometryLibrary.Figures;

public class Rectangle : Figure
{
    private readonly double _height;

    private readonly double _width;

    private readonly string _name;
    
    public sealed override double Perimeter { get; init; }
    
    public sealed override double Square { get; init; }
    
    protected sealed override double _calculatePerimeter()
    {
        return Math.Round((_height + _width) * 2, 8);
    }

    protected sealed override double _calculateSquare()
    {
        return Math.Round(_height * _width, 8);
    }

    public Rectangle(string name, double height, double width)
    {
        RectangleValidator.ValidateName(name);
        RectangleValidator.ValidateSides(height, width);

        _name = name;
        _height = height;
        _width = width;

        Perimeter = _calculatePerimeter();
        Square = _calculateSquare();
    }

    public override string ToString()
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        return "\n" + $"""
                Rectangle {_name} with height: {_height} and width: {_width}
                Perimeter: {Perimeter}
                Square: {Square}
                """;
    }
}