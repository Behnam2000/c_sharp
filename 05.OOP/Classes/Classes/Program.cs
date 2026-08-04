namespace Classes;


class Program
{

    static void Main(string[] args)
    {
        // ---------------- Car Class codes:------------------

        // Creating an object of the Class Car.
        // Creating an instance of the Class Car.
        /*
        Car rally = new Car("405", "Peugeot", false);
        Car gt = new Car("Corvette", "Chevrolet", true);

        System.Console.WriteLine($"{gt.Brand}");

        System.Console.WriteLine("Please enter a brand name as your rally car : ");
        // Setting Brand and Model
        rally.Brand = Console.ReadLine()!;
        System.Console.WriteLine($"Please enter which model of {rally.Brand} you want: ");
        rally.Model = Console.ReadLine()!;

        // Getting Brand and Model
        System.Console.WriteLine($"{rally.Brand} - {rally.Model} is your rally car");


        System.Console.WriteLine("Please enter a brand name as your GT car : ");
        // Setting Brand and Model
        gt.Brand = Console.ReadLine()!;
        System.Console.WriteLine($"Please enter which model of {gt.Brand} you want: ");
        gt.Model = Console.ReadLine()!;

        // Getting Brand and Model
        System.Console.WriteLine($"{gt.Brand} - {gt.Model} is your GT car brand");


        System.Console.WriteLine($"your rally car : {rally.Brand} - {rally.Model} \nAnd your gt car : {gt.Brand} - {gt.Model}");
        */


        // --- Methods in classes:

        Car myAudi = new Car("Quattro", "Audi", false);
        myAudi.Drive();

        Car myLancia = new Car("Delta", "Lancia", true);
        myLancia.Drive();


        // --- static fields:

        Car car = new Car();
        Car car2 = new Car();
        Car car3 = new Car("Silverado", "Chevy", false);
        // accessing the public static variable NumberOfCars of the Car class:
        System.Console.WriteLine("Number of objects of Cars created: " + Car.NumberOfCars);

        //--------------- Customer Class codes: ---------------------

        Customer behnam = new Customer("Behnam");                                           // 1
        Customer behnamWife = new Customer("Bahar", "Asadabad", "09380350620");             // 2

        System.Console.WriteLine($"name of the customer {behnam.Name}");
        System.Console.WriteLine($"address of the behnam's wife {behnamWife.Address}");

        // Default contumer with no atguments given.
        Customer myCustomer = new Customer();                                               // 3
        System.Console.WriteLine($"Default costumer: {myCustomer.Name}");

        System.Console.WriteLine("enter the default costumer name: ");
        //myCustomer.Name = Console.ReadLine()!;
        System.Console.WriteLine("Details about defualt customer: " + myCustomer.Name);


        // ----Methods in classes:

        // Default/optional Parameter for contact number
        myCustomer.SetDetails("Alireza", "seied ahmad");

        System.Console.WriteLine($"My coustomer is: {myCustomer.Name} and lives in: {myCustomer.Address} number: {myCustomer.ContactNumber}");


        // ----Static Keyword:

        Customer.DoSomeCostumerStuff();
        Customer myCustomer2 = new Customer();                                               // 4

        // The DoSomeCustomerStuff method is static and connot be called on objects
        // myCustomer.DoSomeCostumerStuff();

        MyStaticMethod();

        // ----ID of customers:

        behnam.GetDetails();
        behnamWife.GetDetails();
        myCustomer.GetDetails();
        myCustomer2.GetDetails();

        // ----Read only properties:

        System.Console.WriteLine("Customer ID is: " + behnamWife.Id);

        // ----Write-only properties:

        behnam.Password = "Behnam2313";

        // --------------- Rectangle class codes: -----------------------

        Rectangle r1 = new Rectangle("Red");

        // Computed property
        r1.Width = 5;
        r1.Height = 4;

        // overwite (error because it's read-only)
        // r1.Area = 34;

        System.Console.WriteLine("Area of r1 is " + r1.Area);

        //----- readonly and const

        Rectangle r2 = new Rectangle("Green");

        r1.DisplayDetails();
        r2.DisplayDetails();
    }

    // Static Method: is used to declare members of a class that belong to the class itself rather then to
    //      any specifi instance of the class.
    static void MyStaticMethod()
    {
        System.Console.WriteLine("My static Method");
    }

}
