using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Behavioral.Strategy
{
    public class PaypalPaymentService:IPaymentService
    {

        public double CalculateFinalPrice(double amount)
        {
            return amount + amount * 0.2;
        }
    }

}
