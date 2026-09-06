namespace Multicast_Delegates;

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
class Program
{
    static void Main(string[] args)
    {
        Logger logger = new Logger();

        // Creating a multicast delegate
        LogHandler logHandler = logger.LogToConsole;
        logHandler += logger.LogToFile;

        // invoking the multicast delegate
        logHandler("Log this info");

        foreach (LogHandler handler in logHandler.GetInvocationList())
        {
            try
            {
                handler("Event occured with error handling");
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Exception caught: " + ex.Message);
            }
        }


        // Removing a method from the multicast delegate

        if (IsMethodInDelegate(logHandler, logger.LogToFile))
        {
            logHandler -= logger.LogToFile;
            System.Console.WriteLine("LogToFile method removed");
        }
        else
        {
            System.Console.WriteLine("LogToFile Method not found");
        }


        if (logHandler != null)
        {
            InvokeSafely(logHandler, "After removing LogToFile");
        }




    }

    static void InvokeSafely(LogHandler logHandler, string message)
    {
        LogHandler tempLogHandler = logHandler;
        if (tempLogHandler != null)
        {
            tempLogHandler(message);
        }
    }

    static bool IsMethodInDelegate(LogHandler logHandler, LogHandler method)
    {
        if (logHandler == null)
        {
            return false;
        }

        foreach (var d in logHandler.GetInvocationList())
        {
            if (d == (Delegate)method)
            {
                return true;
            }
        }

        return false;
    }
}
