using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcApplication1.App_Start
{
    public class DashRouteHandler : IRouteHandler
    {
        public IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            var routeData = requestContext.RouteData;
            var action = routeData.Values["action"].ToString();
            routeData.Values["action"] = action.Replace("-", "_");
            var handler = new MvcHandler(requestContext);
            return handler;
        }
    }
}