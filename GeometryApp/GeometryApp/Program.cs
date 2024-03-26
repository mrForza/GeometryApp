using GeometryApp.Factories;

namespace GeometryApp;

class Program
{
    private static void Main(string[] args)
    {
        BaseFigureCreator? creator = null;
        var handler = new CommandHandler(creator);
        handler.HandleCommands();
    }
}