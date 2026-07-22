namespace EqualityOperator;

class Program
{
    static void Main(string[] args)
    {
        int num1 = 0;
        int num2 = 0;

        bool isEqual = num1 == num2;

        bool isNotEqual = num1 != num2;

        System.Console.WriteLine("Enter a whole number");

        int age;
        string address;
        // nested if
        if (num1 == int.Parse(Console.ReadLine()!))
        {
            Console.WriteLine("Numbers are equal!");

            Console.WriteLine("Please enter your age");
            age = int.Parse(Console.ReadLine()!);
            if (age >= 18)
            {
                Console.WriteLine("Please enter your address, " +
                    "So that we can send you the price!");

                address = Console.ReadLine()!;
            }
            else
            {
                Console.WriteLine("Sorry, you are not 18");
            }
        }
        else
        {
            Console.WriteLine("Numbers are NOT equal!");
        }

        age = 0;



        // One line if
        int month = 5;
        string monthName;

        if (month == 1)
            monthName = "January";
        else if (month == 2)
            monthName = "February";
        else if (month == 3)
            monthName = "March";
        else
            monthName = "Unknown";


    }
}
