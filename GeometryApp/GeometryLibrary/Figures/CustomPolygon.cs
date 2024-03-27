using GeometryLibrary.Validators;

namespace GeometryLibrary.Figures;

public class CustomPolygon : Figure
{
    private readonly List<Tuple<double, double>> _verticesCoordinates;
    
    public sealed override double Perimeter { get; init; }
    
    public sealed override double Square { get; init; }
    
    protected sealed override double _calculatePerimeter()
    {
        throw new NotImplementedException("This part of task has not been implemented yet");
    }

    protected sealed override double _calculateSquare()
    {
        var firstSum = 0.0;
        var secondSum = 0.0;

        for (var i = 1; i < _verticesCoordinates.Count; ++i)
        {
            firstSum += _verticesCoordinates[i - 1].Item1 * _verticesCoordinates[i].Item2;
            secondSum += _verticesCoordinates[i].Item1 * _verticesCoordinates[i - 1].Item2;
        }
        firstSum += _verticesCoordinates[^1].Item1 * _verticesCoordinates[0].Item2;
        secondSum += _verticesCoordinates[0].Item1 * _verticesCoordinates[^1].Item2;

        return Math.Round(0.5 * Math.Abs(firstSum - secondSum), 8);
    }

    public CustomPolygon(List<Tuple<double, double>> verticesCoordinates)
    {
        _verticesCoordinates = verticesCoordinates;

        // Perimeter = _calculatePerimeter(); NOT IMPLEMENTED
        Square = _calculateSquare();
    }

    public override string ToString()
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        return "\n" + $"""
                       Custom polygon
                       Square: {Square}
                       """;
    }
}