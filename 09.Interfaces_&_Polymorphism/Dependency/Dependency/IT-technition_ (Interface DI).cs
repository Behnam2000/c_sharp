namespace Dependency;

public interface IToolUser
{
    void SetWire(Wire wire);
    void SetCDROM(CDROM cDROM);
}


public class Wire
{
    public void Use()
    {
        System.Console.WriteLine("connecting wires");
    }
}

public class CDROM
{
    public void Use()
    {
        System.Console.WriteLine("installing softwares");
    }
}

public class ITTechnition : IToolUser
{
    private Wire _wire;
    private CDROM _cDROM;


    public void FixComputer()
    {
        _wire.Use();
        _cDROM.Use();
        System.Console.WriteLine("Computer Fixed !");
    }

    public void SetCDROM(CDROM cDROM)
    {
        _cDROM = cDROM;
    }

    public void SetWire(Wire wire)
    {
        _wire = wire;
    }
}