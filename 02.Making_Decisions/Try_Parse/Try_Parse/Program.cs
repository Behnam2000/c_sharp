namespace Try_Parse;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Give me a number");
        string inputString = Console.ReadLine()!;
        int num1 = 0;



        bool isNumber = int.TryParse(inputString, out num1);

        if (isNumber)
        {
            Console.WriteLine("Well Done");
        }
        else
        {
            Console.WriteLine("Haha you troll. You should've entered a number");
        }


        num1++;
        Console.WriteLine("User entered number +1 " + num1);
    }
}
