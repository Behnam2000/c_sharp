using System.Diagnostics;

namespace LogicalOperator;

class Program
{
    static void Main(string[] args)
    {
        bool isRainy = true;
        bool hasUmbrella = false;

        // Logical Operators
        // AND &&
        // OR  ||
        // NOT !

        // Variants of OR statements
        // true || true -> true
        // true || false -> true
        // false|| true -> true
        // false|| false -> false


        // Variants of AND statements
        // true && true -> true
        // true && false -> false
        // false && true -> false
        // false && false -> false

        if (!isRainy || hasUmbrella)
        {
            Console.WriteLine("I'M not getting wet!");
        }


        if (isRainy && !hasUmbrella)
        {
            Console.WriteLine("I'M getting wet!");
        }

    }
}
