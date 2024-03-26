using GeometryLibrary.Figures;

namespace GeometryApp.Factories;

public class TriangleCreator : BaseFigureCreator
{
    public override Figure Create()
    {
        Console.WriteLine("\nEnter the name of triangle: ");
        var name = Console.ReadLine();
        Console.WriteLine("Enter the first side: ");
        var firstSide = double.Parse(Console.ReadLine() ?? "");
        Console.WriteLine("Enter the first side: ");
        var secondSide = double.Parse(Console.ReadLine() ?? "");
        Console.WriteLine("Enter the first side: ");
        var thirdSide = double.Parse(Console.ReadLine() ?? "");
        return new Triangle(name ?? "", firstSide, secondSide, thirdSide);
    }
}