using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Suites;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var paymentManager = new OrderPaymentManager();

            //Validate all payment processors
            var validationResult = paymentManager.Validate();

            if (!validationResult.Success)
            {
                Console.WriteLine("Validation failed");
            }

            //Process all payments (both deposit and authorization)
            var processResult = paymentManager.Process();
           

            if (!processResult.Success)
            {
                // if fails, rollback 
              
                paymentManager.Rollback();
                Console.WriteLine("Rollback process");
            }

           

            //Commit all processor result
            if (processResult.Success)
            {
                paymentManager.Commit();
                Console.WriteLine("Committed process");
            }
        }
    }
}
