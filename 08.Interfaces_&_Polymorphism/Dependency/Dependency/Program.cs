using System.Security.Cryptography;

namespace Dependency;




class Program
{
    static void Main(string[] args)
    {
        // --- Constructor DI-----
        System.Console.WriteLine("------ Constructor DI-----");

        Hammer hammer = new Hammer();
        Saw saw = new Saw();
        Builder builder = new Builder(hammer, saw);

        builder.BuildHouse();



        // --- Setter DI-----
        System.Console.WriteLine("------- Setter DI-----");

        BreakerBar breakerBar = new BreakerBar();   // Create the dependencies Outside
        Screwdriver screwdriver = new Screwdriver();
        Mechanic mechanic = new Mechanic();

        // seting dependencies at this two lines
        mechanic.BreakerBar = breakerBar;       // Inject dependencies via Setters
        mechanic.Screwdriver = screwdriver;     // Inject dependencies via Setters

        mechanic.RepairCar();



        //------ Interface DI ------
        System.Console.WriteLine("------- Interface DI-----");

        Wire wire = new Wire();
        CDROM cDROM = new CDROM();
        ITTechnition iTTechnition = new ITTechnition();

        iTTechnition.SetWire(wire);
        iTTechnition.SetCDROM(cDROM);

        iTTechnition.FixComputer();
    }
}
