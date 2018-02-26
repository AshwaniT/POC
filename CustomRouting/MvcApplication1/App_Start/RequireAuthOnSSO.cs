using System.Net;
using System.Net.Http;
using System.Threading;
//For web api so we are usiong using System.Web.Http.Filters; insetad of MVC filter 
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace MvcApplication1.App_Start
{
    public class RequireAuthOnSSO : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            var principal = Thread.CurrentPrincipal;
            if ( !principal.Identity.IsAuthenticated)
            {
                actionContext.Response = new HttpResponseMessage(HttpStatusCode.Unauthorized);
            }
        }
    }
}