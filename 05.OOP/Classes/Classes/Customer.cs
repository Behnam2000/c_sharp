using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace Classes;

internal class Customer
{
    // ID: Static field to hold the next ID available
    private static int nextId = 0;

    // Read-only instance field initialized from the constructor
    private readonly int _id;

    // Backing field for Write-only property
    private string _password;

    public string Password
    {
        set
        {
            _password = value;
        }
    }

    // Read Only Property
    public int Id
    {
        get
        {
            return _id;
        }
    }

    public string Name { get; set; }
    public string Address { get; set; }
    public string ContactNumber { get; set; }


    // Default Constructor
    public Customer()
    {
        _id = nextId++;
        Name = "No Name";
        Address = "No Address";
        ContactNumber = "No Contact Number";
    }

    // Custom Constructor
    public Customer(string name, string address, string contactNumber)
    {
        _id = nextId++;
        Name = name;
        Address = address;
        ContactNumber = contactNumber;
    }

    // Multiple Constructor (Default/optional Parameter for name)
    public Customer(string name = "No Name")
    {
        _id = nextId++;
        Name = name;
    }

    // Methods in classes: (Default/optional Parameter for contact number)
    public void SetDetails(string name, string address, string contactNumber = "Not Available")
    {
        Name = name;
        Address = address;
        ContactNumber = contactNumber;
    }

    public void GetDetails()
    {
        System.Console.WriteLine($"Details about the customer: {Name} and id is {_id}");
    }


    // Static Keyword
    public static void DoSomeCostumerStuff()
    {
        System.Console.WriteLine("Costumer Stuff");
    }
}
