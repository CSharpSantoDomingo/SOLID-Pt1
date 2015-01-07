using DIP.Common;

namespace DIP.Bad
{
    public class OrderService
    {
        private readonly PaymentService _paymentService;

        public OrderService(PaymentService paymentService)
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
