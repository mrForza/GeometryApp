using GeometryLibrary.Figures;

namespace GeometryLibrary.Tests;

[TestFixture]
public class CircleTests
{
    [Test]
    public void TestCircleConstructorWithNegativeRadius()
    {
        const double radius = -12.5;
        const string name = "Test circle name #1";
        var isGeometryExceptionWasOccured = false;
        
        try
        {
            var circle = new Circle(name, radius);
        }
        catch (GeometryException)
        {
            isGeometryExceptionWasOccured = true;
        }

        Assert.That(isGeometryExceptionWasOccured, Is.EqualTo(true));
    }
    
    [Test]
    public void TestCircleConstructorWithZeroRadius()
    {
        const int radius = 0;
        const string name = "Test circle name #2";
        var isGeometryExceptionWasOccured = false;
        
        try
        {
            var circle = new Circle(name, radius);
        }
        catch (GeometryException)
        {
            isGeometryExceptionWasOccured = true;
        }

        Assert.That(isGeometryExceptionWasOccured, Is.EqualTo(true));
    }
    
    [Test]
    public void TestCircumferenceSimple()
    {
        const double radius = 1.854;
        const string name = "Test circle name #3";

        var circle = new Circle(name, radius);

        Assert.That(Math.Abs(circle.Perimeter - 11.64902555).CompareTo(0.0000001), Is.EqualTo(-1));
    }
    
    [Test]
    public void TestCircleSquareSimple()
    {
        const double radius = 1.854;
        const string name = "Test circle name #3";

        var circle = new Circle(name, radius);

        Assert.That(Math.Abs(circle.Square - 10.79864669).CompareTo(0.0000001), Is.EqualTo(-1));
    }
    
    [Test]
    public void TestCircumferenceHard()
    {
        const double radius = 1215.5323564;
        const string name = "Test circle name #4";

        var circle = new Circle(name, radius);

        Assert.That(Math.Abs(circle.Perimeter - 7637.41504213).CompareTo(0.0000001), Is.EqualTo(-1));
    }
    
    [Test]
    public void TestCircleSquareHard()
    {
        const double radius = 1215.5323564;
        const string name = "Test circle name #4";

        var circle = new Circle(name, radius);

        Assert.That(Math.Abs(circle.Square - 4641762.55148488).CompareTo(0.0000001), Is.EqualTo(-1));
    }
}