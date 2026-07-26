namespace Switch;

class Program
{
    static void Main(string[] args)
    {
        int month = 5;
        string monthName;

        switch (month)
        {
            case 1:
                monthName = "January";
                break;
            case 2:
                monthName = "February";
                break;
            default:
                monthName = "Unkonwn";
                break;
        }

        Console.WriteLine(monthName);

    }
}
