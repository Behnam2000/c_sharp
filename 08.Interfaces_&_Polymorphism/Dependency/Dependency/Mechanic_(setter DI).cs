using System.ComponentModel;

namespace Dependency;

public class BreakerBar
{
    public void Use()
    {
        System.Console.WriteLine("Loosen the fastener");
    }
}

public class Screwdriver
{
    public void Use()
    {
        System.Console.WriteLine("Screwing");
    }
}

// The dependecy is that the Builder depends on the "hammer" and the "saw".
// Now this is where the "saw" and the "hammer" are dependencies of the Builder.
public class Mechanic
{
    public BreakerBar BreakerBar { get; set; }
    public Screwdriver Screwdriver { get; set; }

    // Setter (we don't need constructor at all)

    public void RepairCar()
    {
        BreakerBar.Use();
        Screwdriver.Use();
        System.Console.WriteLine("Car repaired");
    }

}