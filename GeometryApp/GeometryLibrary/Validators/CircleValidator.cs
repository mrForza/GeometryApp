namespace GeometryLibrary.Validators;

public static class CircleValidator
{
    public static void ValidateRadius(double radius)
    {
        if (radius <= 0)
        {
            throw new GeometryException("The radius should be positive!\n");
        }
    }
}