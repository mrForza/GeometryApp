using System.Drawing;
using Rectangle = GeometryLibrary.Figures.Rectangle;

namespace GeometryLibrary.Tests;

[TestFixture]
public class RectangleTests
{
    [Test]
    public void TestRectangleConstructorWithNegativeSides()
    {
        var height = -3.0;
        var width = 5.0;
        var name = "ABCD";
        bool isGeometryExceptionWasOccured = false;
        
        try
        {
            var rectangle = new Rectangle(name, height, width);
        }
        catch (GeometryException geometryException)
        {
            isGeometryExceptionWasOccured = true;
        }

        Assert.That(isGeometryExceptionWasOccured, Is.EqualTo(true));
    }

    [Test]
    public void TestRectangleConstructorWithZeroSides()
    {
        var height = 0.0;
        var width = 5.0;
        var name = "ABCD";
        bool isGeometryExceptionWasOccured = false;
        
        try
        {
            var rectangle = new Rectangle(name, height, width);
        }
        catch (GeometryException geometryException)
        {
            isGeometryExceptionWasOccured = true;
        }

        Assert.That(isGeometryExceptionWasOccured, Is.EqualTo(true));
    }
    
    [Test]
    public void TestRectangleConstructorWithLongIncorrectName()
    {
        var height = 1.0;
        var width = 5.0;
        var name = "ABCDQWKHOQGWIHWRPWQWRPQWRPOQWRPQOWHR";
        bool isGeometryExceptionWasOccured = false;
        
        try
        {
            var rectangle = new Rectangle(name, height, width);
        }
        catch (GeometryException geometryException)
        {
            isGeometryExceptionWasOccured = true;
        }

        Assert.That(isGeometryExceptionWasOccured, Is.EqualTo(true));
    }
    
    [Test]
    public void TestRectangleConstructorWithShortIncorrectName()
    {
        var height = 1.0;
        var width = 5.0;
        var name = "QWE";
        bool isGeometryExceptionWasOccured = false;
        
        try
        {
            var rectangle = new Rectangle(name, height, width);
        }
        catch (GeometryException geometryException)
        {
            isGeometryExceptionWasOccured = true;
        }

        Assert.That(isGeometryExceptionWasOccured, Is.EqualTo(true));
    }
    
    [Test]
    public void TestRectangleConstructorWithLowerCaseIncorrectName()
    {
        var height = 1.0;
        var width = 5.0;
        var name = "abcd";
        bool isGeometryExceptionWasOccured = false;
        
        try
        {
            var rectangle = new Rectangle(name, height, width);
        }
        catch (GeometryException geometryException)
        {
            isGeometryExceptionWasOccured = true;
        }

        Assert.That(isGeometryExceptionWasOccured, Is.EqualTo(true));
    }
    
    [Test]
    public void TestRectanglePerimeter()
    {
        var height = 12.523463;
        var width = 155.8564325;
        var name = "ABCD";
        
        var rectangle = new Rectangle(name, height, width);

        Assert.That(Math.Abs(rectangle.Perimeter - 336.759791).CompareTo(0.0000001), Is.LessThanOrEqualTo(-1));
    }
    
    [Test]
    public void TestRectangleSquare()
    {
        var height = 12.523463;
        var width = 155.8564325;
        var name = "ABCD";
        
        var rectangle = new Rectangle(name, height, width);

        Assert.That(Math.Abs(rectangle.Square - 1951.86226572).CompareTo(0.0000001), Is.LessThanOrEqualTo(-1));
    }
}