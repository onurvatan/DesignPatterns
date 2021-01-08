using System;
using DesignPatterns.Patterns.Behavioral.Strategy;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var paymentClient = new PaymentClient(new PaypalPaymentService());
            var totalAmount = paymentClient.MakePayment(100);
            Console.WriteLine("Total Amount: " + totalAmount);

            paymentClient.ChangeStrategy(new LocalBankPaymentService());
            totalAmount = paymentClient.MakePayment(100);

            Console.WriteLine("Total Amount: " + totalAmount);
            Console.ReadLine();

        }
    }
}
