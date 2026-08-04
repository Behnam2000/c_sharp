using System.Drawing;

namespace ListsApp;

class Program
{
    static void Main(string[] args)
    {
        // Declaring a list and initializing it:
        List<string> colors = [
            "red",
            "blue",
            "green",
            "red"
        ];

        colors.Add("blue");

        System.Console.WriteLine("Current colors in the colors list:");
        foreach (string color in colors)
        {

            System.Console.WriteLine(color);
        }

        // Removes the first occurence of a specific object from the List<T>
        // colors.Remove("red");

        // remove every "red" in the list
        bool isDeletingSuccessful = colors.Remove("red");
        while (isDeletingSuccessful)
        {
            isDeletingSuccessful = colors.Remove("red");
        }

        System.Console.WriteLine("Current colors in the colors list:");
        foreach (string color in colors)
        {

            System.Console.WriteLine(color);
        }

    }
}
