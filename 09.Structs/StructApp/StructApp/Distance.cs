namespace StructApp;

public struct Distance
{
    // It's common practice to make structs immutable
    // by declaring all fields as readonly and providing only
    // get accessors for properties:
    public double X { get; }

    public double Y { get; }

    public Distance(double x, double y)
    {
        X = x;
        Y = y;
    }

    // Struct can have methods
    public void DisplayDistance()
    {
        System.Console.WriteLine($"Distance: {X}, {Y}");
    }
    
    public double DistanceTo(Distance other)
    {
        double dx = other.X - X;
        double dy = other.Y - Y;
        return Math.Sqrt(dx * dx + dy * dy);
    }
}