using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumable
{
   public interface IPriceCalculator
    {
       int Calculate(Product product);
    }
}
