using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Behavioral.Strategy
{
    public class PaymentClient:IPaymentClient
    {
        private readonly IPaymentService _paymentService;
        public PaymentClient(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }
        public double MakePayment(double amount)
        {
            return _paymentService.CalculateFinalPrice(amount);
        }
    }

    public interface IPaymentClient
    {
        public double MakePayment(double amount);
    }
}
