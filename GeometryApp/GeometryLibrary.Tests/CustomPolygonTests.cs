using GeometryLibrary.Figures;

namespace GeometryLibrary.Tests;

[TestFixture]
public class CustomPolygonTests
{
    [Test]
    public void TestCustomPolygonSquare()
    {
        var vertices = new List<Tuple<double, double>>()
        {
            new Tuple<double, double>(3, 4),
            new Tuple<double, double>(5, 11),
            new Tuple<double, double>(12, 8),
            new Tuple<double, double>(9, 5),
            new Tuple<double, double>(5, 6)
        };

        var polygon = new CustomPolygon(vertices);
        Assert.That(Math.Abs(polygon.Square - 30.0).CompareTo(0.0000001), Is.LessThanOrEqualTo(-1));
    }
}