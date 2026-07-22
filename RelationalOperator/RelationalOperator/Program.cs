namespace RelationalOperator;

class Program
{
    static void Main(string[] args)
    {
        int num1 = 6;
        int num2 = 5;

        // Relational Operator : <   <=   >    >=

        // isHigher by default is set to "false". only after you initialize it with a different value it will be overwrittern
        bool isHigher = num2 > num1;


        Console.WriteLine("Enter your age");
        int age = int.Parse(Console.ReadLine()!);

        if (age >= 18)
        {
            Console.WriteLine("You can party in club");
            return;
        }

        if (age <= 6)
        {
            Console.WriteLine("You are a baby");
            return;
        }

        Console.WriteLine("Is your parents with you?");
        bool isWithParents = bool.Parse(Console.ReadLine()!);


        if (age >= 13 && isWithParents)
        {
            Console.WriteLine("You can party in club");
        }
        else if (age >= 6)
        {
            Console.WriteLine("You can party in school");
        }

    }
}
