namespace Polymorphism;

public class Animal
{
    public virtual void MakeSound()
    {
        System.Console.WriteLine("Some generic animal sound");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        System.Console.WriteLine("Bark");
    }
}

public class Cat : Animal
{
    public override void MakeSound()
    {
        System.Console.WriteLine("Mewoo..");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Part 2 of Polymorphism: (using inheritance using 'virtual' and 'override')
        // The dog is inheriting from animal
        Animal myPet = new Dog();
        myPet.MakeSound();


        // ------------ IPaymentProcessor codes ----------
        System.Console.WriteLine("\n------------ IPaymentProcessor codes ---------- ");

        // Polymorphism (using interfaces)
        // The CreditCardProcessor & PaypalProcessor is implementing (not inheriting) form IPaymentProcessor
        IPaymentProcessor creditCardProcessor = new CreditCardProcessor();
        PaymentService paymentService = new PaymentService(creditCardProcessor);
        paymentService.ProcessOrderPayment(100.00m);

        IPaymentProcessor paypalProcessor = new PaypalProcessor();
        paymentService = new PaymentService(paypalProcessor);
        paymentService.ProcessOrderPayment(1099.00m);
    }
}
