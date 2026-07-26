namespace Random_Number;

class Program
{
    static void Main(string[] args)
    {
        // creating an instance of the Random Class
        Random random = new Random();
        // this will give us the random number
        int randomNumber = random.Next(1, 11);


        Console.WriteLine("Give me a number");
        string inputString = Console.ReadLine()!;
        int num1 = 0;


        bool isNumber = int.TryParse(inputString, out num1);

        if (isNumber)
        {
            while (num1 != randomNumber)
            {
                System.Console.WriteLine(randomNumber);
                Console.WriteLine("YOU GUESSED IT WRONG. Try again");
                inputString = Console.ReadLine()!;
                isNumber = int.TryParse(inputString, out num1);

            }


            Console.WriteLine("YOU GUESSED RIGHT");


        }
        else
        {
            Console.WriteLine("Haha you troll. You should've entered a number");
        }


    }
}
