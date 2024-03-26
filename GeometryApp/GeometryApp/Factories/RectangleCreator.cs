using GeometryLibrary.Figures;

namespace GeometryApp.Factories;

public class RectangleCreator : BaseFigureCreator
{
    public override Figure Create()
    {
        Console.WriteLine("\nEnter the name of rectangle: ");
        var name = Console.ReadLine();
        Console.WriteLine("Enter the height of rectangle: ");
        var height = double.Parse(Console.ReadLine() ?? string.Empty);
        Console.WriteLine("Enter the height of rectangle: ");
        var width = double.Parse(Console.ReadLine() ?? string.Empty);

        return new Rectangle(name ?? "", height, width);
    }
}