namespace Inheritance;

class Program
{
    static void Main(string[] args)
    {
        Dog myDog = new Dog();
        myDog.MakeSound();
        myDog.Eat();

        Cat myCat = new Cat();
        myCat.MakeSound();


        // Person and Employee Class Codes: ------------------------------
        System.Console.WriteLine("\n--------------Person and Employee Class codes: ---------------------");

        Employee joe = new Employee("Joe", 34, "Sales", 5432);
        joe.DisplayEmployeeInfo();

        Manager carl = new Manager("Carl", 54, "Manager", 5252, 7);
        carl.DisplayManagerInfo();

        // XML documented
        carl.BecomeOlder(5);
        carl.DisplayPersonInfo();



    }
}

// Base Class (Parent Class or SuperClass)
class Animal
{
    public void Eat()
    {
        System.Console.WriteLine("Eating...");
    }

    // virtual keyword in used to make a method override-able
    public virtual void MakeSound()
    {
        System.Console.WriteLine("Animal makes a generic sound");
    }

}

// Derived Class (Child Class or Subclass): inherits the members of the base class 
class Dog : Animal
{
    public override void MakeSound()
    {
        // call the base class specific method to access it (and override it)
        base.MakeSound();
        System.Console.WriteLine("Barking___");
    }

}

class Cat : Animal
{
    public override void MakeSound()
    {
        System.Console.WriteLine("Cat is meowing....");
    }

}

class Collie : Dog
{
    public void GoingNuts()
    {
        System.Console.WriteLine("Collie going nuts..!");
    }
}
