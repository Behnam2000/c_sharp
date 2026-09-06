namespace InterfaceApp;

class Program
{
    public interface IAnimal
    {
        void MakeSound();
        void Eat(string food);
    }


    public class Dog : IAnimal
    {
        public void Eat(string food)
        {
            System.Console.WriteLine("Dog ate " + food);
        }

        public void MakeSound()
        {
            System.Console.WriteLine("Bark");
        }
    }

    public class Cat : IAnimal
    {
        public void Eat(string food)
        {
            System.Console.WriteLine("Cat ate " + food);
        }

        public void MakeSound()
        {
            System.Console.WriteLine("Meeow..");
        }
    }


    static void Main(string[] args)
    {
        Dog dog = new Dog();
        dog.MakeSound();
        dog.Eat("treat");

        Cat cat = new Cat();
        cat.MakeSound();
        cat.Eat("fish");


        // ----- IVehicle Interface codes: ----------
        System.Console.WriteLine("\n----- IVehicle Interface codes: ----------");
        Car car = new Car();
        car.Drive();

        Truck truck = new Truck();
        truck.Drive();



    }


}
