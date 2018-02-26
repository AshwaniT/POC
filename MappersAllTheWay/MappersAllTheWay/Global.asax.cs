using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using AutoMapper;
using MappersAllTheWay.App_Start;

namespace MappersAllTheWay
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            //regiter automapper profile
            Mapper.Initialize(x => x.AddProfile<ContactUsProfile>());
        }
    }
}