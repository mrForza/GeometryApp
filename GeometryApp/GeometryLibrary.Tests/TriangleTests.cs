using GeometryLibrary.Figures;

namespace GeometryLibrary.Tests;

[TestFixture]
public class TriangleTests
{
    [Test]
    public void TestTriangleConstructorWithNegativeSides()
    {
        const double firstSide = -1.5;
        var secondSide = 3.0;
        var thirdSide = 5.0;
        var name = "ABC";
        bool isGeometryExceptionWasOccured = false;
        
        try
        {
            var triangle = new Triangle(name, firstSide, secondSide, thirdSide);
        }
        catch (GeometryException geometryException)
        {
            isGeometryExceptionWasOccured = true;
        }

        Assert.That(isGeometryExceptionWasOccured, Is.EqualTo(true));
    }

    [Test]
    public void TestTriangleConstructorWithIncorrectSides()
    {
        var firstSide = 1.0;
        var secondSide = 2.0;
        var thirdSide = 11.0;
        var name = "ABC";
        bool isGeometryExceptionWasOccured = false;
        
        try
        {
            var triangle = new Triangle(name, firstSide, secondSide, thirdSide);
        }
        catch (GeometryException geometryException)
        {
            isGeometryExceptionWasOccured = true;
        }

        Assert.That(isGeometryExceptionWasOccured, Is.EqualTo(true));
    }
    
    [Test]
    public void TestTriangleConstructorWithLongIncorrectName()
    {
        var firstSide = 3.0;
        var secondSide = 4.0;
        var thirdSide = 5.0;
        var name = "ACBAJCOASCSICPSJCPOASCASJCOPSO";
        bool isGeometryExceptionWasOccured = false;
        
        try
        {
            var triangle = new Triangle(name, firstSide, secondSide, thirdSide);
        }
        catch (GeometryException geometryException)
        {
            isGeometryExceptionWasOccured = true;
        }

        Assert.That(isGeometryExceptionWasOccured, Is.EqualTo(true));
    }
    
    [Test]
    public void TestTriangleConstructorWithShortIncorrectName()
    {
        var firstSide = 3.0;
        var secondSide = 4.0;
        var thirdSide = 5.0;
        var name = "A";
        bool isGeometryExceptionWasOccured = false;
        
        try
        {
            var triangle = new Triangle(name, firstSide, secondSide, thirdSide);
        }
        catch (GeometryException geometryException)
        {
            isGeometryExceptionWasOccured = true;
        }

        Assert.That(isGeometryExceptionWasOccured, Is.EqualTo(true));
    }
    
    [Test]
    public void TestTriangleConstructorWithLowerCaseIncorrectName()
    {
        var firstSide = 3.0;
        var secondSide = 4.0;
        var thirdSide = 5.0;
        var name = "abc";
        bool isGeometryExceptionWasOccured = false;
        
        try
        {
            var triangle = new Triangle(name, firstSide, secondSide, thirdSide);
        }
        catch (GeometryException geometryException)
        {
            isGeometryExceptionWasOccured = true;
        }

        Assert.That(isGeometryExceptionWasOccured, Is.EqualTo(true));
    }
    
    [Test]
    public void TestTriangleConstructorWithSatisfyingParameters()
    {
        var firstSide = 3.0;
        var secondSide = 4.0;
        var thirdSide = 5.0;
        var name = "ABC";
        bool isGeometryExceptionWasOccured = false;
        
        try
        {
            var triangle = new Triangle(name, firstSide, secondSide, thirdSide);
        }
        catch (GeometryException geometryException)
        {
            isGeometryExceptionWasOccured = true;
        }

        Assert.That(isGeometryExceptionWasOccured, Is.EqualTo(false));
    }
    
    [Test]
    public void TestTrianglePerimeter()
    {
        var firstSide = 3.1158720;
        var secondSide = 4.32785;
        var thirdSide = 5.43657536;
        var name = "ABC";
        
        var triangle = new Triangle(name, firstSide, secondSide, thirdSide);

        Assert.That(triangle.Perimeter, Is.EqualTo(12.88029736));
    }
    
    [Test]
    public void TestTriangleSquare()
    {
        var firstSide = 3.1158720;
        var secondSide = 4.32785;
        var thirdSide = 5.43657536;
        var name = "ABC";
        
        var triangle = new Triangle(name, firstSide, secondSide, thirdSide);
        
        Assert.That(Math.Abs((triangle.Square - 6.73672385)).CompareTo(0.0000001), Is.EqualTo(-1));
    }
    
    [Test]
    public void TestTriangleIsRightTrue()
    {
        var firstSide = 3.0;
        var secondSide = 4.0;
        var thirdSide = 5.0;
        var name = "ABC";
        
        var triangle = new Triangle(name, firstSide, secondSide, thirdSide);
        Assert.That(triangle.IsRightTriangle(), Is.EqualTo(true));
    }
    
    [Test]
    public void TestTriangleIsRightFalse()
    {
        var firstSide = 1.0;
        var secondSide = 3.0;
        var thirdSide = 2.5;
        var name = "ABC";
        
        var triangle = new Triangle(name, firstSide, secondSide, thirdSide);
        Assert.That(triangle.IsRightTriangle(), Is.EqualTo(false));
    }
}