using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.App_Start
{
    //overridding view engine.is it?
    public class WebSiteViewEngine : RazorViewEngine
    {
        public WebSiteViewEngine()
        {
            ViewLocationFormats = new[]
                                      {
                                          "~/Views/{1}/{0}.aspx",
                                          "~/Views/{1}/{0}.ascx",
                                          "~/Views/Shared/{0}.aspx",
                                          "~/Views/Shared/{0}.ascx",
                                          "~/Views/{1}/{0}.cshtml",
                                          "~/Views/{1}/{0}.vbhtml",
                                          "~/Views/Shared/{0}.cshtml",
                                          "~/Views/Shared/{0}.vbhtml",
                                          "~/Common/Views/{1}/{0}.cshtml",
                                          "~/Common/Views/{1}/{0}.vbhtml",
                                          "~/Common/Views/Shared/{0}.cshtml",
                                          "~/Common/Views/Shared/{0}.cshtml"
                                      };
            PartialViewLocationFormats = ViewLocationFormats;
            MasterLocationFormats = ViewLocationFormats;

            //TODO: MVC, add area stuff

        }
    }
}