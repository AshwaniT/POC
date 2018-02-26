using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suites
{
    [Serializable]
    public class OrderPaymentInputSet
    {
        public OrderPaymentType PaymentType { get; set; }
        public decimal TotalAmountToProcess { get; set; }
        public List<OrderPaymentInput> OrderPayments { get; set; }

        public OrderPaymentInputSet()
        {
            OrderPayments = new List<OrderPaymentInput>();
        }
    }
}
