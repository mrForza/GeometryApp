using GeometryLibrary;
using GeometryLibrary.Figures;

namespace GeometryApp.Factories;

public class CustomPolygonCreator : BaseFigureCreator
{
    public override Figure Create()
    {
        Console.WriteLine("\nEnter the number of vertices: ");
        var n = int.Parse(Console.ReadLine() ?? "0");
        var verticesCoordinates = new List<Tuple<double, double>>();

        if (n <= 0)
        {
            throw new GeometryException("You should pass positive quantity of vertices");
        }
        
        var i = 0;
        while (i < n)
        {
            Console.WriteLine($"Enter x_{i}: ");
            var x = double.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine($"Enter y_{i}: ");
            var y = double.Parse(Console.ReadLine() ?? "0");
            verticesCoordinates.Add(new Tuple<double, double>(x, y));
            ++i;
        }

        return new CustomPolygon(verticesCoordinates);
    }
}