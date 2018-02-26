using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suites
{
    /// <summary>
    /// results for either order validation or order authorization
    /// </summary>
    [Serializable]
    public class PaymentProcessResult
    {
        public string OrderId { get; set; }
        public bool Success { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        
    }
}
