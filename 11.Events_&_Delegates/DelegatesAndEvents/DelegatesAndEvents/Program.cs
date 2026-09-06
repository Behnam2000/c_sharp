namespace DelegatesAndEvents;

class Program
{
    // 1. Delecate Declaration:
    public delegate void Notify(string message);
    // Declaration of a delegate could be inside or outside of a class.
    //


    static void Main(string[] args)
    {
        // Delegates define a method signature,
        // and any mehtod assigned to a delegate must mathch this signature.

        // 2. Instantiation:
        Notify notifyDelegate = ShowMessage;
        // Notify notifyDelegate = new Notify(notifyDelegate);  // older approach


        // 3. Invocation:
        notifyDelegate("Hello, Delegates!");


        //------------- Logger class codes -------------------
        System.Console.WriteLine("\n------ Logger class codes -------------------");

        Logger logger = new Logger();
        LogHandler logHandler = logger.LogToConsole;
        logHandler("Logging to console");

        logHandler = logger.LogToFile;
        logHandler("Log some files");


        // ---------------- Generic static method codes --------------
        System.Console.WriteLine("\n----- Generic static method codes --------------");

        int[] intArr = { 1, 2, 3, 4, 5 };
        string[] stringArr = { "One", "Two", "Three", "Four", "Five" };

        PrintArray(intArr);
        PrintArray(stringArr);


        // ------------ Event Class codes: ---------------------------
        System.Console.WriteLine("------------ Event Class codes: ---------------------------");

        EventPublisher publisher = new EventPublisher();
        EventSubscriber subscriber = new EventSubscriber();

        publisher.OnNotify += subscriber.OnEventRaised;

        publisher.RaiseEvent("test");
    }

    static void ShowMessage(string message2)
    {
        System.Console.WriteLine(message2);
    }

    // Generic very brief look: creat one method and use it for all data types.
    public static void PrintArray<T>(T[] array)
    {
        foreach (T item in array)
        {
            System.Console.WriteLine(item);
        }
    }



}
