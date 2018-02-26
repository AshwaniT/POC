using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suites
{
    public interface IOrderPaymentProcessor : IUnitOfWork
    {
        bool IsProcessed { get; }
        PaymentProcessorSequenceType PipeLineSequence { get; }
        PaymentProcessResult Process();
        PaymentProcessResult Validate();
    }
}
