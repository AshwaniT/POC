using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suites
{
    public class GiftCardAuthorizationProcessor : IOrderPaymentProcessor
    {
        private readonly OrderPaymentInput _orderPaymentInput;
        private bool _processSuccess;


        public bool IsProcessed { get; private set; }

        public PaymentProcessorSequenceType PipeLineSequence
        {
            get
            {
                return PaymentProcessorSequenceType.CreditCardAuthorization;
            }
        }

        public GiftCardAuthorizationProcessor(OrderPaymentInput orderPaymentInput)
        {
           
            _orderPaymentInput = orderPaymentInput;
           
        }



        public PaymentProcessResult Process()
        {
            //authorized credit card may be using Cybersource if all goes right
            IsProcessed = true;
            _processSuccess = true;
            return new PaymentProcessResult {Success = true};
        }

        public PaymentProcessResult Validate()
        {
            //Do credit cart validation 
            return new PaymentProcessResult {Success = true};
        }

        public void Commit()
        {
            if(!IsProcessed)
                return; 
            //if processed saved authorization details

        }

        public void Rollback()
        {
            if (!IsProcessed)
                return;
            if (_processSuccess)
                Commit();
            //else rollback

            IsProcessed = false;
        }
    }
}
