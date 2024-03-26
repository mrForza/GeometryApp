using GeometryLibrary.Figures;

namespace GeometryLibrary.Tests;

[TestFixture]
public class CircleTests
{
    [Test]
    public void TestCircleConstructorWithNegativeRadius()
    {
        var radius = -12.5;
        var name = "Test circle name #1";
        bool isGeometryExceptionWasOccured = false;
        
        try
        {
            var triangle = new Circle(name, radius);
        }
        catch (GeometryException geometryException)
        {
            isGeometryExceptionWasOccured = true;
        }

        Assert.That(isGeometryExceptionWasOccured, Is.EqualTo(true));
    }
    
    [Test]
    public void TestCircleConstructorWithZeroRadius()
    {
        var radius = 0;
        var name = "Test circle name #2";
        bool isGeometryExceptionWasOccured = false;
        
        try
        {
            var triangle = new Circle(name, radius);
        }
        catch (GeometryException geometryException)
        {
            isGeometryExceptionWasOccured = true;
        }

        Assert.That(isGeometryExceptionWasOccured, Is.EqualTo(true));
    }
    
    [Test]
    public void TestCircumference()
    {
        var radius = 1.854;
        var name = "Test circle name #3";

        var circle = new Circle(name, radius);

        Assert.That(Math.Abs(circle.Perimeter - 11.64902555).CompareTo(0.0000001), Is.EqualTo(-1));
    }
    
    [Test]
    public void TestCircleSquare()
    {
        var radius = 1.854;
        var name = "Test circle name #3";

        var circle = new Circle(name, radius);

        Assert.That(Math.Abs(circle.Square - 10.79864669).CompareTo(0.0000001), Is.EqualTo(-1));
    }
}