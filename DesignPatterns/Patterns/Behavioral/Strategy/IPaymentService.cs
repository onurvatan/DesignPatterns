using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Behavioral.Strategy
{
    public  interface  IPaymentService
    {
        double CalculateFinalPrice(double amount);
    }
}
