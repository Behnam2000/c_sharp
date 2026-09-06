namespace Polymorphism;

public interface IPaymentProcessor
{
    void ProcessPayment(decimal amount);
}