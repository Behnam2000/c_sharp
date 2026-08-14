namespace Nullable;

class Program
{
    static void Main(string[] args)
    {
        int? age = null; // int? is a nullable int

        int myAge = 26;

        if (age.HasValue)
        {
            System.Console.WriteLine("age is: " + age.Value);

            int sum = age.Value + myAge;
        }
        else
        {
            System.Console.WriteLine("Age is not specified");
        }

    }
}
