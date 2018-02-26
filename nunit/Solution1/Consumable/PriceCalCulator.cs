using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumable
{
    public class PriceCalCulator : IPriceCalculator
    {
        private readonly List<Offer> _offer;
        public PriceCalCulator(List<Offer> offer)
        {
            _offer = offer;
        }
        public int Calculate(Product product)
        {
            //switch (product.Name)
            //{
            //    case "Dove Soap":
            //        var freeproducts = product.Quantity / 2;
            //        return (product.Quantity - freeproducts) * product.UnitPrice;
            //    default:
            //        return product.Quantity * product.UnitPrice;
            //}
            if (_offer!=null && _offer.Any())
            {
                var offer = _offer.FirstOrDefault(x => x.ProductName.Equals(product.Name));
                if (offer != null)
                {
                   // var freeproducts = (product.Quantity / offer.Buy) * offer.Get;
                    var bucket = product.Quantity / (offer.Buy + offer.Get);
                    var idealProduct = product.Quantity - (offer.Buy * bucket);

                    return ((offer.Buy * bucket) * product.UnitPrice) + (idealProduct * product.UnitPrice);
                }
            }
            return product.Quantity * product.UnitPrice;
        }
    }
}
