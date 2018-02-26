using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;


namespace Suites
{
    public class OrderPaymentManager : IUnitOfWork
    {
        private List<IOrderPaymentProcessor> _paymentProcessors = new List<IOrderPaymentProcessor>();
       

        public OrderPaymentManager()
        {
          

            RegisterPaymentProcessors();
        }

        private void RegisterPaymentProcessors()
        {
            //based pn user payment option selection _paymentProcessors 

            _paymentProcessors.Add(new CreditCardAuthorizationProcessor(new OrderPaymentInput{PaymentMethod = PaymentMethod.CreditCard}));
            _paymentProcessors.Add(new GiftCardAuthorizationProcessor(new OrderPaymentInput { PaymentMethod = PaymentMethod.GiftCertificate }));
            

            _paymentProcessors = _paymentProcessors.OrderBy(a => a.PipeLineSequence).ToList();
        }

        public PaymentProcessResultSet Validate()
        {
            var resultBuilder = new PaymentProcessResultBuilder();

            foreach (var result in _paymentProcessors.Select(p => p.Validate()))
            {
                resultBuilder.AddPaymentProcessResult(result);

                if (!result.Success)
                    break;
            }

            return resultBuilder.ToResultSet();
        }

        public PaymentProcessResultSet Process()
        {
            var resultBuilder = new PaymentProcessResultBuilder();

            foreach (var result in _paymentProcessors.Select(p => p.Process()))
            {
                resultBuilder.AddPaymentProcessResult(result);

                if (!result.Success)
                    break;
            }

            return resultBuilder.ToResultSet();
        }

        public void Commit()
        {
            using (var scope = new TransactionScope())
            {
                foreach (var processor in _paymentProcessors)
                {
                    processor.Commit();
                }

                scope.Complete();
            }
        }

        public void Rollback()
        {
            using (var scope = new TransactionScope())
            {
                foreach (var processor in _paymentProcessors)
                {
                    processor.Rollback();
                }

                scope.Complete();
            }
        }
    }
}
