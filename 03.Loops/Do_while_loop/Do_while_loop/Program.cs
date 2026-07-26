// this is the loop that executes at least one time during running
// so the do-while loop is a post-test loop, while loop is a pre-test loop
int number;

do
{
    System.Console.WriteLine("Enter a positive whole number: ");
    number = int.Parse(Console.ReadLine()!);
} while (number <= 0);
Console.WriteLine("Finally...");