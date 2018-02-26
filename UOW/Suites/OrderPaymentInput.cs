using System;

namespace Suites
{
    [Serializable]
    public class OrderPaymentInput
    {
        public int Id { get; set; }
        public long EntityId { get; set; }
        public int Sequence { get; set; }
        public string OrderId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public decimal AmountToProcess { get; set; }
    }
}
