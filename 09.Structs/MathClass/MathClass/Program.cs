namespace MathClass;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Celling: " + Math.Ceiling(15.3));
        System.Console.WriteLine("Floor: " + Math.Floor(15.3));

        int num1 = 13;
        int num2 = 9;
        System.Console.WriteLine($"Lower of num1 {num1} and {num2} is {Math.Min(num1, num2)}");
        System.Console.WriteLine($"Higher of num1 {num1} and {num2} is {Math.Max(num1, num2)}");

        System.Console.WriteLine($"3 to power of 5 is {Math.Pow(3, 5)}");
        System.Console.WriteLine($"PI is {Math.PI}");

        System.Console.WriteLine($"The square root of 25 is {Math.Sqrt(25)}");
        System.Console.WriteLine($"Always positive is {Math.Abs(-25)}");

        System.Console.WriteLine($"cos of 1 is: {Math.Cos(1)}");
    }
}
