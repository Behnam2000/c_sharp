namespace Dependency;

public class Hammer
{
    public void Use()
    {
        System.Console.WriteLine("Hammering Nails");
    }
}

public class Saw
{
    public void Use()
    {
        System.Console.WriteLine("Sawing wood");
    }
}

// The dependecy is that the Builder depends on the "hammer" and the "saw".
// Now this is where the "saw" and the "hammer" are dependencies of the Builder.
public class Builder
{
    private Hammer _hammer;
    private Saw _saw;

    public Builder(Hammer hammer, Saw saw)
    {
        // Builder is responsible for creating its dependencies.
        // _hammer = new Hammer();
        // _saw = new Saw();

        // But now instead of the builder being responsible to create its dependencies,
        // now it happens through injection.
        //-------(Constructor Dependency Injection) --------:
        _hammer = hammer;
        _saw = saw;
    }

    public void BuildHouse()
    {
        _hammer.Use();
        _saw.Use();
        System.Console.WriteLine("House built");
    }

}