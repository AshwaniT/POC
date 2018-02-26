using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suites
{

    [Serializable]
    public class PaymentProcessResultSet
    {
        private readonly List<PaymentProcessResult> _processResults;

        public bool Success { get { return _processResults.All(x => x.Success); } }
        public List<PaymentProcessResult> PaymentProcessResults { get { return _processResults; } }

        public PaymentProcessResultSet(List<PaymentProcessResult> processResults)
        {
            _processResults = processResults;
        }
    }
}
