namespace GeometryLibrary.Validators;

public static class TriangleValidator
{
    public static void ValidateTriangleSides(double firstSide, double secondSide, double thirdSide)
    {
        if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
        {
            throw new GeometryException("The side of triangle should be positive!\n");
        }
        
        if (firstSide >= secondSide + thirdSide
            || secondSide >= firstSide + thirdSide
            || thirdSide >= firstSide + secondSide)
        {
            throw new GeometryException("You have created a triangle with incorrect sides!\n");
        }
    }

    public static void ValidateTriangleName(string name)
    {
        if (name.Length != 3 || !name.Any(char.IsUpper))
        {
            throw new GeometryException("You have input an incorrect triangle name! The triangle name should consist " +
                                        "of only 3 upper case different letters\n");
        }
    } 
}