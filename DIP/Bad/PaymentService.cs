using DIP.Common;

namespace DIP.Bad
{
    public class PaymentService
    {
        /// <summary>
        /// Pay a order and get reference from processor
        /// </summary>
        /// <param name="paymentInformation"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        public string PayOrder(PaymentInformation paymentInformation, decimal amount)
        {
            const string paymentConfirmationReference = "123456789";

            //Do Stuff for make payment in processor

            return paymentConfirmationReference;
        }
    }
}
