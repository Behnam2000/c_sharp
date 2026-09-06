namespace Polymorphism;

class CreditCardProcessor : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        System.Console.WriteLine($"Processing credit card service with amount: " + amount);
        // Implement credit card payment logic
    }
}