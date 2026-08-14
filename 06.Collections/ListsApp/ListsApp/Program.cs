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

        // --------- List Class codes ------------
        System.Console.WriteLine("\n--------Sorting Class codes:");
        Lists list = new Lists();

        // Sort():
        list.Numbers.Sort();

        System.Console.WriteLine("Sort() sorting numbers in our list:");
        foreach (int number in list.Numbers)
        {
            System.Console.WriteLine(number);
        }

        // findAll();
        // return a list of numbers that are 10 and higher   (lambda)
        List<int> higherEqualTen = list.Numbers.FindAll(x => x >= 10);

        System.Console.WriteLine("findAll() numbers 10 or higher in our list:");
        foreach (int num in higherEqualTen)
        {
            System.Console.WriteLine(num);
        }

        // ------------ Lambda class codes: --------------
        System.Console.WriteLine("\n----------Lambda Class Codes:");
        Lambda lambda = new Lambda();

        // Lambda _ Predicate
        List<int> higherTen = list.Numbers.FindAll(lambda.isGreaterThanTen);

        System.Console.WriteLine("findAll() (Predicate) numbers higher than 10 in our list:");
        foreach (int num in higherTen)
        {
            System.Console.WriteLine(num);
        }


        // Any:
        bool hasLargeNumber = list.Numbers.Any(x => x > 20);
        if (hasLargeNumber)
        {
            System.Console.WriteLine("There are large(> 20) numbers in the numbers list");
        }
        else
        {
            System.Console.WriteLine("Now large(> 20) numbers in the numbers list");
        }


        // ------------ Products class codes: --------------
        System.Console.WriteLine("\n----------Products Class Codes:");

        // Declare a list of complex objects with initial values
        List<Products> product = new List<Products>{
            new Products { Name = "Drive Shaft", Price = 8000.00 },
            new Products {Name = "Shaft Seal", Price = 1000.00},
            new Products { Name = "Gearbox Bushing", Price = 2500.00}
        };

        // Add items to the list
        product.Add(new Products { Name = "Carburetor", Price = 12000.00 });


        List<Products> cheapProducts = product.Where(p => p.Price < 5000.00).ToList();


        System.Console.WriteLine("Available Products");
        // Iterate through the list
        foreach (Products prod in product)
        {
            System.Console.WriteLine($"Product: {prod.Name}, Price {prod.Price}");
        }


        System.Console.WriteLine("Available Products for less than 5 milion: ");
        foreach (Products prod in cheapProducts)
        {
            System.Console.WriteLine($"Product: {prod.Name}, Price {prod.Price}");
        }

    }
}
