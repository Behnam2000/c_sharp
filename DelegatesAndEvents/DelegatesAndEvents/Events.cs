namespace DelegatesAndEvents;


public delegate void Notify(string message);

public class EventPublisher
{
    // The "On" prefix makes it immediately clear that the method is associated with an event.
    // It signfies that the method is not just a regular method but one that is called when a 
    //  specific event occurs.
    public event Notify OnNotify;

    public void RaiseEvent(string message)
    {
        OnNotify?.Invoke(message); // Invoke the even there are any subscribers
    }

}

public class EventSubscriber
{
    public void OnEventRaised(string message)
    {
        System.Console.WriteLine("Event received: " + message);
    }
}