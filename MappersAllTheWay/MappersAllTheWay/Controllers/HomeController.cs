using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MappersAllTheWay.Models;

namespace MappersAllTheWay.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var dummy = GetDummy();
            //painful mapping
            var viewMOdel = new ContactUsViewModel
            {
                Name = dummy.FirstName + " " + dummy.LastName,
                LastName = dummy.LastName,
                Comments = dummy.Comments,
                FirstName = dummy.FirstName,
                Phone = dummy.Phone
            };
            return View(viewMOdel);
        }

        private ContactUsModel GetDummy()
        {
            return new ContactUsModel()
            {
                Comments = "Test comment.",
                FirstName = "Ashwani",
                LastName = "Tiwari",
                Id = 1,
                Phone = "1234567891"
            };
        }

        public ActionResult Map()
        {
            //keep you controller slim
            //neet and clean

            return View("Index", AutoMapper.Mapper.Map<ContactUsModel, ContactUsViewModel>(GetDummy()));
        }
    }
}
