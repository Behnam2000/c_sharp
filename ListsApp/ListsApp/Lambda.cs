namespace ListsApp;

internal class Lambda
{
    // A lambda expression consists of 2 parts:
    //  1. Parameters
    //  2. Expression or Statement Block

    // Parameters are written on the left side of => (this symbol is read as "goes to" or "becomes").
    // The expression or action to perform is on the right side.

    // This reads as:
    // "Take an input x and turn it into x multiplied by x".
    // x => x * x;

    // if we want to make a method out of it:
    static int Squaring(int num1)
    {
        return num1 * num1;
    }


    /*
    In C#, a "delegate" is like a pointer or a regerence to a method.
        It allows you to pass methods as arguments to other methods,
        store them in variables, and call them later.
        This is useful when you want your code to be flexible and able to handle different bahaviors that
        aren't prederemined.
    */

    /*
    "Predicate" is the "delegate" like "Func" and "Action" delegates, It represents a method containing
        a set of criteria and checks whether the passed parameter meets those criteria.
        predicate delegate methods must take one input parameter and return a boolean - true or false.
        (An anonymous method can also be assigned to a Predicate delegate type).
        (A lambda expression can also be assigned to a Predicate delegate type).
    */

    // Predicate:
    // Define the predicate to check if a number is greater than 10
    public Predicate<int> isGreaterThanTen = x => x > 10;


    // Predicate
    // Using a separete method as an expression for the Predicate:
    public Predicate<int> isGreaterThanSeven = IsGreaterThanSeven;


    // a separate alternative method for lambda: "x => x > 7":
    public static bool IsGreaterThanSeven(int x)
    {
        return x > 7;
    }
}