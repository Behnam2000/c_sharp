namespace InterfaceApp;

class Car : IVehicle
{
    public void Drive()
    {
        System.Console.WriteLine("Car is Driving");
    }
}