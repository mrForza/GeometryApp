namespace GeometryLibrary.Figures;

public abstract class Figure
{
    public abstract double Perimeter { get; init; }
    
    public abstract double Square { get; init; }

    protected abstract double _calculatePerimeter();

    protected abstract double _calculateSquare();
}