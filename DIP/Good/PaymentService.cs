using DIP.Common;

namespace DIP.Good
{
    public class PaymentService : IPaymentService
    {
        public string PayOrder(PaymentInformation paymentInformation, decimal amount)
        {
            const string paymentConfirmationReference = "123456789";

            //Do Stuff for make payment in processor

            return paymentConfirmationReference;
        }
    }
}
