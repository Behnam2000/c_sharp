namespace Inheritance;

class Manager : Employee
{
    public int TeamSize { get; private set; }

    public Manager(string name, int age, string jobTitle, int employeeId, int teamSize) : base(name, age, jobTitle, employeeId)
    {
        TeamSize = teamSize;
    }

    public void DisplayManagerInfo()
    {
        DisplayEmployeeInfo();
        System.Console.WriteLine($"Team Size: {TeamSize}");
    }

}