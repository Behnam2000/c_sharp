namespace EventArgs_EventHandler;



// public delegate void TemperatureChangedHandler(string message);

public class TemperatureChangedEventArgs : EventArgs
{
    // Property holding the temperature
    public int Temperature { get; }

    // constructor
    public TemperatureChangedEventArgs(int temperature)
    {
        Temperature = temperature;
    }
}


public class TemperatureMonitor
{

    // Using the Generic Delegate EventHandler<TEventArgs>
    public event EventHandler<TemperatureChangedEventArgs> TemperatureChanged;

    //public event TemperatureChangedHandler OnTemperatureChanged;

    private int _temperature;

    public int Temperature
    {
        get { return _temperature; }

        set
        {

            if (_temperature != value)
            {
                _temperature = value;
                // Raise Event
                OnTemperatureChanged(new TemperatureChangedEventArgs(_temperature));
            }
        }

    }

    protected virtual void OnTemperatureChanged(TemperatureChangedEventArgs e)
    {
        // Letting every subscriber know!
        TemperatureChanged?.Invoke(this, e);
    }
}


// Subscriber 1
public class TemperatureAlert
{
    public void OnTemperatureChanged(object sender, TemperatureChangedEventArgs e)
    {
        System.Console.WriteLine($"Alert: temperature is {e.Temperature}  sender is : {sender}");
    }
}

// Subscriber 1
public class TempCoolingAlert
{
    public void OnTemperatureChanged(object sender, TemperatureChangedEventArgs e)
    {
        System.Console.WriteLine($"TEMP Cooling: temperature is {e.Temperature}  sender is : {sender}");
    }
}



class Program
{
    static void Main(string[] args)
    {
        TemperatureMonitor monitor = new TemperatureMonitor();
        TemperatureAlert alert = new TemperatureAlert();
        TempCoolingAlert tempCoolingAlert = new TempCoolingAlert();

        monitor.TemperatureChanged += alert.OnTemperatureChanged;
        monitor.TemperatureChanged += tempCoolingAlert.OnTemperatureChanged;

        monitor.Temperature = 20;

        System.Console.WriteLine("Enter Temp:");
        monitor.Temperature = int.Parse(Console.ReadLine()!);

    }
}
