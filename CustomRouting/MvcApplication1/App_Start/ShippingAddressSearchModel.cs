using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.App_Start
{
    public class ShippingAddressSearchModel
    {
        public int Top { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public bool ShowAddressPageNumber { get; set; }
    }
}