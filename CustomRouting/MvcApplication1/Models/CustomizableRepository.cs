using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class CustomizableRepository: ICustomizableRepository
    {
        public bool IsCustomizable(string sku)
        {
            return true;
        }

        public CustomizedProduct Save(CustomizedProduct product)
        {
            return product;
        }
    }
}