namespace Conversions;

class Program
{
    static void Main(string[] args)
    {
        // implicit conversion
        int myInt = 1368321474;

        double myDouble = myInt;

        long myLong = myInt;

        float myFloat = 125.125f;

        myDouble = myFloat;


        // explicit conversion (Casting)

        int myInt2 = (int)myLong;
        Console.WriteLine(myInt2); // Wrong Number 

        myDouble = 12.12345678912345;
        myFloat = (float)myDouble;
        Console.WriteLine(myFloat);

        int myInt3;
        double myDouble3 = 13.5;
        myInt3 = (int)myDouble3;   // Cuts off the decimal points
        Console.WriteLine(myInt3);


        // Conversion Helpers Parse and Convert

        string numberString = "123";
        int result = int.Parse(numberString); // only works with interger in a string

        string myBoolString = "true";
        bool myBool = Convert.ToBoolean(myBoolString);
        Console.WriteLine($"myBool is {myBool}");
    }
}
