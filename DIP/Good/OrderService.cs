using DIP.Common;

namespace DIP.Good
{
    public class OrderService: IOrderService
    {
        private readonly IPaymentService _paymentService;

        public OrderService(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        public void MakeAOrder(Order order)
        {
            //Validations, BLA BLA BLA :P

            //Do Payment with PaymentService
            _paymentService.PayOrder(order.PaymentInformation, order.Amount);
        }
    }
}
