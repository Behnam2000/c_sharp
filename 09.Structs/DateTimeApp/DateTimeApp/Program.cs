using System.Net;
using System.Runtime.CompilerServices;

namespace DateTimeApp;

class Program
{
    static void Main(string[] args)
    {
        DateTime dateTime = new DateTime(2001, 1, 13);

        System.Console.WriteLine("My bithday is {0}", dateTime);

        // Write today on screen
        System.Console.WriteLine(DateTime.Today);

        // Write current time on screen
        System.Console.WriteLine(DateTime.Now);


        DateTime tomorrow = GetTomorrow();

        System.Console.WriteLine("Tomorrow will be the {0}", tomorrow);
        System.Console.WriteLine("Today is {0}", DateTime.Today.DayOfWeek);
        System.Console.WriteLine(GetFirstDayOfYear(1999));

        int days = DateTime.DaysInMonth(2001, 1);
        System.Console.WriteLine("Days in Jan 2001: {0}", days);

        DateTime now = DateTime.Now;

        // display the time in this structure x o'clock y minutes and z seconds
        System.Console.WriteLine("{0} o'clock {1} minutes and {2} seconds", now.Hour, now.Minute, now.Second);

        System.Console.WriteLine("write a date in this format: yyyy-mm-dd");
        string input = Console.ReadLine()!;
        if (DateTime.TryParse(input, out dateTime))
        {
            System.Console.WriteLine(dateTime);
            TimeSpan daysPassed = now.Subtract(dateTime);
            System.Console.WriteLine("Days passed since: {0}", daysPassed.Days);

        }
        else
        {
            System.Console.WriteLine("Wrong word");
        }

    }

    static DateTime GetTomorrow()
    {
        return DateTime.Today.AddDays(1);
    }

    static DateTime GetFirstDayOfYear(int year)
    {
        return new DateTime(year, 1, 1);
    }


}
