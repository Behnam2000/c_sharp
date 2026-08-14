namespace Dictionaries;

class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Salary { get; set; }


    public Employee(string name, int age, int salary)
    {
        Name = name;
        Age = age;
        Salary = salary;
    }
}


class Program
{
    static void Main(string[] args)
    {
        // key - value

        // declaring and initializing a dictionary
        Dictionary<int, string> employees = new Dictionary<int, string>();

        // Adding items to a dictionary
        employees.Add(101, "Ali Tabrizi");
        employees.Add(102, "Sara Rezaei");
        employees.Add(103, "Bahram Radan");
        employees.Add(104, "Shahin Parvaei");
        employees.Add(105, "Nima Azimi");
        employees.Add(106, "Hasti khodadadi");

        // access items in a dictionary
        string name = employees[101];
        System.Console.WriteLine(name);

        // Update data
        employees[103] = "Behnam Safari";

        // Remove an item
        employees.Remove(101);

        // Handling Duplicate
        if (!employees.ContainsKey(104))
        {
            employees.Add(104, "Mina Jamali");
        }

        bool added = employees.TryAdd(102, "Micheal Jacksonn");
        if (!added)
        {
            System.Console.WriteLine("Employee is exists");
        }


        int counter = 103;
        while (employees.ContainsKey(counter))
        {
            counter++;
        }
        employees.Add(counter, "Mobina ghahremani");


        // iterating over a dictionary
        foreach (KeyValuePair<int, string> employee in employees)
        {
            System.Console.WriteLine($"ID: {employee.Key}, Name: {employee.Value}");
        }


        // -------------------- Employee class code-------------
        System.Console.WriteLine("\nEmployee class codes: ");

        Dictionary<int, Employee> emps = new Dictionary<int, Employee>();


        emps.Add(1, new Employee("Brian Fury", 27, 100000));
        emps.Add(2, new Employee("Sara deamon", 23, 120000));
        emps.Add(3, new Employee("Robin Diaz", 30, 90000));
        emps.Add(4, new Employee("James Louis", 21, 78000));

        foreach (var item in emps)
        {
            System.Console.WriteLine($"ID: {item.Key} Name: {item.Value.Name}" +
                $"Salary {item.Value.Salary}" +
                $"Age {item.Value.Age}"
            );
        }



        // ------ Another way to declare dics plus strings as key

        var codes = new Dictionary<string, string>
        {
            ["NY"] = "New York",
            ["CA"] = "California",
            ["TX"] = "Texas"
        };



        if (codes.TryGetValue("NY", out string state))
        {
            System.Console.WriteLine(state);
        }

        foreach (var item in codes)
        {
            System.Console.WriteLine($"The statecode is {item.Key}" +
                $" the state name is: {item.Value}"
            );
        }



        
    }
}
