using GeometryLibrary.Validators;

namespace GeometryLibrary.Figures;

public class Triangle : Figure
{
    private readonly double _firstSide;

    private readonly double _secondSide;

    private readonly double _thirdSide;

    private readonly string _name;

    protected sealed override double _calculatePerimeter()
    {
        return Math.Round(_firstSide + _secondSide + _thirdSide, 8);
    }

    protected sealed override double _calculateSquare()
    {
        var semiPerimeter = Perimeter / 2;
        return Math.Round(double.Sqrt(semiPerimeter * (semiPerimeter - _firstSide)
                                         * (semiPerimeter - _secondSide) 
                                         * (semiPerimeter - _thirdSide)), 8);
    }
    
    public sealed override double Perimeter { get; init; }
    
    public sealed override double Square { get; init; }

    public bool IsRightTriangle()
    {
        var sides = new List<double>() { _firstSide, _secondSide, _thirdSide };
        var minSide = sides.Min();
        var maxSide = sides.Max();
        return Math.Abs(
            Math.Pow(minSide, 2) + Math.Pow(Perimeter - minSide - maxSide, 2)
            - Math.Pow(maxSide, 2)).CompareTo(0.0000001) == -1;
    }

    public Triangle(string name, double firstSide, double secondSide, double thirdSide)
    {
        TriangleValidator.ValidateTriangleSides(firstSide, secondSide, thirdSide);
        TriangleValidator.ValidateTriangleName(name);
        
        _firstSide = firstSide;
        _secondSide = secondSide;
        _thirdSide = thirdSide;
        _name = name;
        
        Perimeter = _calculatePerimeter();
        Square = _calculateSquare();
    }

    public override string ToString()
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        return "\n" + $"""
                Triangle {_name} with sides: {_firstSide} {_secondSide} {_thirdSide}
                Perimeter: {Perimeter}
                Square: {Square}
                """;
    }
}