namespace StructApp;

public struct Point
{
    // It's common practice to make structs immutable
    // by declaring all fields as readonly and providing only
    // get accessors for properties:

    // public int X { get; set; }

    // public int Y { get; set; }

    public int X;

    public int Y;

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    // Struct can have methods
    public void Display()
    {
        System.Console.WriteLine($"Point: {X}, {Y}");
    }


}


public class PointClass
{
    public int X { get; set; }
    public int Y { get; set; }


    public PointClass(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void Display()
    {
        Console.WriteLine($"Point: ({X},{Y})");
    }
}


class Program
{
    static void Main(string[] args)
    {
        // Point p1 = new Point(10, 20);
        // p1.Display();

        // Strcuts can declare without "new" keyword (all fields (not properties) must be initialized at the point
        //  when they are used.
        // Point p2;
        // p2.X = 10;
        // p2.Y = 20;
        // we use fields in the this method and they must be initialize at that point:
        // p2.Display();

        // Struct are value types. only passing values form p1 to p3. not the referece of p1 to p3
        // Point p3 = p1;
        // p3.X = 50;
        // p1.Display();
        // p3.Display();


        //----------- Distance class codes:-------------
        System.Console.WriteLine("\nDistance class codes:-------------");

        Distance pd1 = new Distance(20, 40);
        pd1.DisplayDistance();

        Distance pd2 = new Distance(40, 50);
        pd1.DisplayDistance();

        double distance = pd1.DistanceTo(pd2);
        System.Console.WriteLine($"{distance:F3}");


        // ------------ Difference Between Value Types and Reference Types ----------
        System.Console.WriteLine("\n------------ Difference Between Value Types and Reference Types ----------");

        Point p1 = new Point(10, 20);
        p1.Display();

        Point p2 = p1; // p2 is a copy of p1
        p2.Display();
        p2.X = 25; // Changes p2, p1 remains unchanged
        Console.WriteLine("After changing p2.X to 25");
        p1.Display();
        p2.Display();

        Console.WriteLine("NOW COME THE CLASS OBJECTS");
        PointClass pC1 = new PointClass(1, 2);
        PointClass pC2 = pC1; // pC2 is a reference to the same object as pC1
        pC1.Display();
        pC2.Display();


        pC2.X = 3; // Changes p1.X as well, since p1 and p2 reference the same object
        Console.WriteLine("After changing pC2.X to 3");
        pC1.Display();
        pC2.Display();

        bool isEqual = pC1.Equals(pC2);
        Console.WriteLine("is it equal? " + isEqual);
        Console.ReadKey();
    }
}
