using GeometryApp.Factories;
using GeometryLibrary;
using GeometryLibrary.Figures;

namespace GeometryApp;

public class CommandHandler(BaseFigureCreator? creator)
{
    private BaseFigureCreator? _creator = creator;

    private void _printIsTriangleRight()
    {
        if (_creator?.Create() is Triangle triangle)
        {
            if (triangle.IsRightTriangle())
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\nYES");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("\nNO");
            }
        }
        else
        {
            Console.WriteLine("Your figure is not a triangle!");
        }
    }

    private const string HelpText = "\n" + """
                                            Available commands:
                                            0 - Exit the program
                                            1 - Enter 3 sides of triangle and get it's info
                                            2 - Enter 3 sides of triangle and determine if it is right
                                            3 - Enter the radius of circle and get it's info
                                            4 - Enter the height and width of rectangle and get it's info
                                            5 - Enter coordinates of vertices of polygon and get it's info\n
                                            """;

    public void HandleCommands()
    {
        while (true)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(HelpText + "\n");
                var command = int.Parse(Console.ReadLine() ?? "0");
                switch (command)
                {
                    case 0:
                        return;
                    case 1: // Triangle
                        _creator = new TriangleCreator();
                        break;
                    case 2: // Check if triangle is a right (Прямоугольный)
                        _printIsTriangleRight();
                        continue;
                    case 3: // Circle
                        _creator = new CircleCreator();
                        break;
                    case 4: // Rectangle
                        _creator = new RectangleCreator();
                        break;
                    case 5: // Custom polygon
                        _creator = new CustomPolygonCreator();
                        break;
                    default:
                        Console.WriteLine("You should pass a correct command!\n");
                        break;
                }

                Console.WriteLine(_creator?.Create());
            }
            catch (GeometryException geometryException)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(geometryException.Message + "\n");
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nSomething went wrong! Please, check again your input\n");
            }
        }
    }
}