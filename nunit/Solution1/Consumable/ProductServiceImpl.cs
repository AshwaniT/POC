using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumable
{
   public class ProductServiceImpl: IProductService
    {
        public int GetProductUnitPrice(string name)
        {
            //TODO
            switch (name)
            {
                case "Dove Soap":
                    return 30;
                case "Axe Deos":
                    return 100;
                default:
                    return 0;
            }
        }
    }
}
