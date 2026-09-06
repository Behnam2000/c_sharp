namespace TempMonitor_Events;

public delegate void TemperatureChangeHandler(string message);

public class TemperatureMonitor
{
    public event TemperatureChangeHandler OnTemperatureChanged;

    private int _temperature;
    
    public int Temperature
    {
        get { return _temperature; }

        set
        {
            _temperature = value;
            if (_temperature > 30)
            {
                RaisedTemperatureChangedEvent("Temperature is above thereshold");
            }

        }

    }

    protected virtual void RaisedTemperatureChangedEvent(string message)
    {
        OnTemperatureChanged?.Invoke(message);
    }
}


public class TemperatureAlert
{
    public void OnTemperatureChanged(string message)
    {
        System.Console.WriteLine("Alert: " + message);
    }
}



class Program
{
    static void Main(string[] args)
    {
        TemperatureMonitor monitor = new TemperatureMonitor();
        TemperatureAlert alert = new TemperatureAlert();

        monitor.OnTemperatureChanged += alert.OnTemperatureChanged;

        monitor.Temperature = 20;
        System.Console.WriteLine("Enter Temperature: ");
        monitor.Temperature = int.Parse(Console.ReadLine()!);

    }
}
