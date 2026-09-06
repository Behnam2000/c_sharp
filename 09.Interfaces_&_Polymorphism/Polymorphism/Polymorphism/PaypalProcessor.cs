namespace Polymorphism;

class PaypalProcessor : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        System.Console.WriteLine($"Processing paypal service with amount: " + amount);
        // Implement paypal payment logic
    }
}