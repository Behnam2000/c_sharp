namespace Inheritance;

public class Person
{
    public string Name { get; private set; }
    public int Age { get; private set; }

    // base class constructor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
        System.Console.WriteLine("Person constructor called");
    }

    public void DisplayPersonInfo()
    {
        System.Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
    //--------------- XML comments -------------------------

    /// <summary>Makes our object older</summary>
    /// <param name="years">The parameter holds the amout of years the object should age </param>
    /// <returns>Returns the new age after aging/becoming older</returns>
    public int BecomeOlder(int years)
    {
        Age = Age + years;

        return Age;
    }
}

