using DIP.Common;

namespace DIP.Good
{
    public interface IPaymentService
    {
        string PayOrder(PaymentInformation paymentInformation, decimal amount);
    }
}
