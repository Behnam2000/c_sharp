using System.Diagnostics;

namespace Try_Catch;

class Program
{
    static void Main(string[] args)
    {
        int result = 0;

        Debug.WriteLine("Main method is running");
        try
        {
            System.Console.WriteLine("Please enter a number");

            int num1 = int.Parse(Console.ReadLine()!);

            // int num1 = 0;
            int num2 = 2;

            result = num2 / num1;

        }
        catch (DivideByZeroException ex)
        {
            System.Console.WriteLine("Do not " + ex.Message);
        }
        catch (FormatException ex)
        {
            System.Console.WriteLine("Enter a number: " + ex.Message);
        }
        catch (OverflowException ex)
        {
            System.Console.WriteLine("number to high: " + ex.Message);
        }

        // this defualt exception manages all other kinds of exceptions that we didn't specifically catch. (Parent)
        catch (Exception ex)
        {
            System.Console.WriteLine("Error: " + ex.Message);

            // This is only executing during "Debugging"
            Debug.WriteLine(ex.ToString());
        }



        finally
        {
            System.Console.WriteLine("This always executes");
        }

        System.Console.WriteLine("Result: " + result);



        // ------------ Throw  Keyword ---------------------------
        System.Console.WriteLine("\n ------------ Throw  Keyword ------------");

        System.Console.WriteLine("Enter your age: ");
        GetUserAge(Console.ReadLine()!);


        // --------- How Exception work with Call Stack -------------
        System.Console.WriteLine("\n --------- How Exception work with Call Stack -------------");

        System.Console.WriteLine("App running before");
        try
        {
            LevelOne();
        }
        catch (Exception ex)
        {
            System.Console.WriteLine("Exception caught in Main: " + ex.Message);
        }
        System.Console.WriteLine("App running after");
    }

    // ------------ Throw  Keyword ---------------------------

    static int GetUserAge(string input)
    {
        int age;
        if (!int.TryParse(input, out age))
        {
            throw new Exception("You didn't enter a valid age");

        }
        if (age < 0 || age > 120)
        {
            throw new Exception("Your age must be between 0 and 120");
        }

        return age;
    }


    // --------- How Exception work with Call Stack -------------

    static void LevelOne()
    {
        LevelTwo();
    }

    static void LevelTwo()
    {
        throw new Exception("Something went wrong!");
    }

}
