
using DesignPatterns.Patterns.Behavioral.Strategy;
using Xunit;

namespace DesignPatterns.Tests.Tests.Behavioral.Strategy
{

    public class Test
    {
        [Fact]
        public void When_Payment_Method_Is_Paypal_Make_Payment_Must_Return_Two_Percent_Commission()
        {
            //arrange

            var paymentClient = new PaymentClient(new PaypalPaymentService());

            //act
            var result = paymentClient.MakePayment(100);

            //assert
            Assert.Equal(120, result);
        }


        [Fact]
        public void When_Payment_Method_Is_LocalBank_Make_Payment_Must_Return_One_Percent_Commission()
        {
            //arrange

            var paymentClient = new PaymentClient(new LocalBankPaymentService());

            //act
            var result = paymentClient.MakePayment(100);

            //assert
            Assert.Equal(110, result);
        }

    }
}
