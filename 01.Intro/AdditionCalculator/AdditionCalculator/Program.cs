namespace AdditionCalculator;

class Program
{
    static void Main(string[] args)
    {   // Prints out whatever is inside of ()
        Console.WriteLine("Enter first number");
        // datatype variableName = initial value;
        double firstNumber = 0.0;
        double secondNumber = 0;

        // Takes the user input and stores it
        // Variable with the name "userInput" and the data type string
        string userInput = Console.ReadLine()!;
        firstNumber = double.Parse(userInput);

        Console.WriteLine("Enter second number");

        userInput = Console.ReadLine()!;
        secondNumber = double.Parse(userInput);

        double result = firstNumber + secondNumber;

        result = Math.Round(result, 2);

        Console.WriteLine($"{firstNumber} + {secondNumber} = {result}");

        Console.ReadLine();

    }
}
