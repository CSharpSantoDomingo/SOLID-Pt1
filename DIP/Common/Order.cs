using System;

namespace DIP.Common
{
    public class Order
    {
        public decimal Amount { get; set; }
        public PaymentInformation PaymentInformation { get; set; }
    }

    public class PaymentInformation
    {
        public string CreditCardHolderName { get; set; }
        public string CreditCardNumber { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Ccv { get; set; }
        public CardType CardType { get; set; }
    }

    public enum CardType
    {
        Visa,
        MasterCard,
        AmericanExpress
    }
}
