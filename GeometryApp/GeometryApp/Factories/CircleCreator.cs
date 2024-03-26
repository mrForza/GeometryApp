using GeometryLibrary.Figures;

namespace GeometryApp.Factories;

public class CircleCreator : BaseFigureCreator
{
    public override Figure Create()
    {
        Console.WriteLine("\nEnter the name of circle: ");
        var name = Console.ReadLine();
        Console.WriteLine("Enter the radius of circle: ");
        var radius = double.Parse(Console.ReadLine() ?? string.Empty);
        return new Circle(name ?? "", radius);
    }
}