namespace DelegatesAndEvents;

public delegate void LogHandler(string message);

class Logger
{
    public void LogToConsole(string message)
    {
        System.Console.WriteLine("Console log: " + message);
    }

    public void LogToFile(string message)
    {
        System.Console.WriteLine("File log: " + message);
    }
}