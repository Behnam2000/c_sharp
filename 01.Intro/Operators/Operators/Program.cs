namespace Operators;

class Program
{
    static void Main(string[] args)
    {
        // Operators and Order of Evaluation
        int num1 = 5;
        int num2 = 13;

        Console.WriteLine("Addition num1 + num2 = " + (num1 + num2));

        //Order of Evaluation
        Console.WriteLine("Subtraction num1 - num2 = " + (num1 - num2));
        // "Subtraction num1 - num2 = 5" - 13 => using the () fixed it

        Console.WriteLine("Multiplication num1 * num2 = " + num1 * num2);
        Console.WriteLine("Divition num1 / num2 = " + num1 / num2);
    }
}

