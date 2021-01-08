using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Behavioral.Strategy
{
    public class LocalBankPaymentService:IPaymentService
    {
        public double CalculateFinalPrice(double amount)
        {
            return amount + amount * 0.1;
        }
    }

}
