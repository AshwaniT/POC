using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.App_Start;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public string Test([ModelBinder(typeof (ShippingAddressSearchModelBinder))] ShippingAddressSearchModel model)
        {
            return model.ToString();
        }

    }
}
