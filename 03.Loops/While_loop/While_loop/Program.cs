
System.Console.WriteLine("For Loop:");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}


System.Console.WriteLine("\nWhile Loop:");
// The While Loop

Random random = new Random();
int secretNumber = random.Next(1, 101);
int userGuess = 0;
int counter = 0;

while (userGuess != secretNumber)
{
    System.Console.WriteLine("Enter your guess: ");
    userGuess = int.Parse(Console.ReadLine()!);
    counter++;

    if (userGuess < secretNumber)
    {
        System.Console.WriteLine("Too Low; Try a higher number");
    }
    else if (userGuess > secretNumber)
    {
        System.Console.WriteLine("Too high; Try a lower number");
    }
    else
    {
        System.Console.WriteLine("Congratulations! YOU GUESSED IT RIGHT: " + secretNumber + "\nIT took you " + counter + " times to guess it");
    }
}


