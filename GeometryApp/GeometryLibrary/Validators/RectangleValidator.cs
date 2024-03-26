namespace GeometryLibrary.Validators;

public static class RectangleValidator
{
    public static void ValidateName(string name)
    {
        if (name.Length != 4 || !name.Any(char.IsUpper))
        {
            throw new GeometryException("You have input an incorrect rectangle name! The triangle name should consist " +
                                        "of only 4 upper case different letters\n");
        }
    }

    public static void ValidateSides(double height, double width)
    {
        if (height <= 0 || width <= 0)
        {
            throw new GeometryException("The side of rectangle should be positive!\n");
        }
    }
}