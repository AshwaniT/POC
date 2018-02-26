using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.App_Start
{
    public class BaseController : Controller
    {
        private HttpContext _context;
        //public IMvcWebSite WebSite
        //{
        //    get
        //    {
        //        return WebSiteAdmin.GetMvcSite();
        //    }
        //}

        //public IObjectMapper Mapper
        //{
        //    get { return ObjectFactory.GetInstance<IObjectMapper>(); }
        //}

        //protected UserSessionManagerViewModel UserSessionManager
        //{
        //    get
        //    {
        //        return WebSite.UserSessionManager;
        //    }
        //}

        protected HttpContext Context
        {
            get
            {
                return _context ?? (_context = System.Web.HttpContext.Current);
            }
        }

       // protected IUserSessionManagerContext UserSessionManagerContext { get { return WebSite.UserSessionManagerContext; } }
    }
}