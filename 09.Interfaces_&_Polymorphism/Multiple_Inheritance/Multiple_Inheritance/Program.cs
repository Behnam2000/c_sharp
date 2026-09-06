namespace Multiple_Inheritance;

public interface IPrintable
{
    void Print();
}

public interface IScanable
{
    void Scan();
}

// inplementing (or inheriting) from two different interfaces which is more flixable
public class MultiFunctionPrinter : IPrintable, IScanable
{
    public void Print()
    {
        System.Console.WriteLine("Printig document");
    }

    public void Scan()
    {
        System.Console.WriteLine("Scanning document");
    }
}


class Program
{
    static void Main(string[] args)
    {
        MultiFunctionPrinter printer = new MultiFunctionPrinter();
        printer.Print();
        printer.Scan();

    }
}
