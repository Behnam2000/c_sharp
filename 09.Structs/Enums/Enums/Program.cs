namespace Enums;

// enums are there to share set of constant to keep the library consestant
enum Day { Mo, Tu, We, Th, Fr, Sa, Su };

// we can reassign the index and it'll keep on counting from that point:
enum Month { Jan = 1, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec }

class Program
{
    static void Main(string[] args)
    {
        Day fr = Day.Fr;
        Day su = Day.Fr;

        Day a = Day.Fr;

        System.Console.WriteLine("Days:");

        System.Console.WriteLine(fr == a);

        System.Console.WriteLine(Day.Mo);
        System.Console.WriteLine((int)Day.Mo);



        System.Console.WriteLine("\nMounts:");

        System.Console.WriteLine((int)Month.Feb);
        System.Console.WriteLine((int)Month.Aug);
    }
}
