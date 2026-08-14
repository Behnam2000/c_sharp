namespace Inheritance;

public class Employee : Person
{
    public string JobTitle { get; private set; }

    public int EmployeeID { get; private set; }

    public Employee(string name, int age, string jobTitle, int employeeId) : base(name, age)
    {
        JobTitle = jobTitle;
        EmployeeID = employeeId;
        System.Console.WriteLine("Employee (derived class) constructor called");
    }

    public void DisplayEmployeeInfo()
    {
        DisplayPersonInfo();
        System.Console.WriteLine($"Job Title: {JobTitle}, Employee id: {EmployeeID}");
    }
}