using Rectangle = GeometryLibrary.Figures.Rectangle;

namespace GeometryLibrary.Tests;

[TestFixture]
public class RectangleTests
{
    [Test]
    public void TestRectangleConstructorWithNegativeSides()
    {
        const double height = -3.0;
        const double width = 5.0;
        const string name = "ABCD";
        var isGeometryExceptionWasOccured = false;
        
        try
        {
            var rectangle = new Rectangle(name, height, width);
        }
        catch (GeometryException)
        {
            isGeometryExceptionWasOccured = true;
        }

        Assert.That(isGeometryExceptionWasOccured, Is.EqualTo(true));
    }

    [Test]
    public void TestRectangleConstructorWithZeroSides()
    {
        const double height = 0.0;
        const double width = 5.0;
        const string name = "ABCD";
        var isGeometryExceptionWasOccured = false;
        
        try
        {
            var rectangle = new Rectangle(name, height, width);
        }
        catch (GeometryException)
        {
            isGeometryExceptionWasOccured = true;
        }

        Assert.That(isGeometryExceptionWasOccured, Is.EqualTo(true));
    }
    
    [Test]
    public void TestRectangleConstructorWithLongIncorrectName()
    {
        const double height = 1.0;
        const double width = 5.0;
        const string name = "ABCDQWKHOQGWIHWRPWQWRPQWRPOQWRPQOWHR";
        var isGeometryExceptionWasOccured = false;
        
        try
        {
            var rectangle = new Rectangle(name, height, width);
        }
        catch (GeometryException)
        {
            isGeometryExceptionWasOccured = true;
        }

        Assert.That(isGeometryExceptionWasOccured, Is.EqualTo(true));
    }
    
    [Test]
    public void TestRectangleConstructorWithShortIncorrectName()
    {
        const double height = 1.0;
        const double width = 5.0;
        const string name = "QWE";
        var isGeometryExceptionWasOccured = false;
        
        try
        {
            var rectangle = new Rectangle(name, height, width);
        }
        catch (GeometryException)
        {
            isGeometryExceptionWasOccured = true;
        }

        Assert.That(isGeometryExceptionWasOccured, Is.EqualTo(true));
    }
    
    [Test]
    public void TestRectangleConstructorWithLowerCaseIncorrectName()
    {
        const double height = 1.0;
        const double width = 5.0;
        const string name = "abcd";
        var isGeometryExceptionWasOccured = false;
        
        try
        {
            var rectangle = new Rectangle(name, height, width);
        }
        catch (GeometryException)
        {
            isGeometryExceptionWasOccured = true;
        }

        Assert.That(isGeometryExceptionWasOccured, Is.EqualTo(true));
    }
    
    [Test]
    public void TestRectanglePerimeter()
    {
        const double height = 12.523463;
        const double width = 155.8564325;
        const string name = "ABCD";
        
        var rectangle = new Rectangle(name, height, width);

        Assert.That(Math.Abs(rectangle.Perimeter - 336.759791).CompareTo(0.0000001), Is.LessThanOrEqualTo(-1));
    }
    
    [Test]
    public void TestRectangleSquare()
    {
        const double height = 12.523463;
        const double width = 155.8564325;
        const string name = "ABCD";
        
        var rectangle = new Rectangle(name, height, width);

        Assert.That(Math.Abs(rectangle.Square - 1951.86226572).CompareTo(0.0000001), Is.LessThanOrEqualTo(-1));
    }
}