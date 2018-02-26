using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumable
{
   public class Cart
    {
       private readonly IProductService _productService;
       private readonly IPriceCalculator _priceCalculator;
       public Cart(IProductService productService, IPriceCalculator priceCalculator)
       {
           _productService = productService;
           _priceCalculator = priceCalculator;
           Products = new List<Product>();
       }
        public List<Product> Products { get; set; }
        public int CartTotal
        {
            get
            {
                return Products.Sum(x => x.ItemTotal);
            }
        }
        public void AddProducts(List<Product> products)
        {
            //fetch price for each product and update
            foreach (var item in products)
            {
                item.UnitPrice = _productService.GetProductUnitPrice(item.Name);
                item.ItemTotal = _priceCalculator.Calculate(item);
                Products.Add(item);
            }
            

        }
        
    }
}
