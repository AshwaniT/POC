using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.App_Start
{
    //why abstract class 
    public abstract class BaseWebViewPage : WebViewPage
    {
        //private IIncludeHelper _includeHelper;
        //public IMvcWebSite WebSite { get { return WebSiteAdmin.GetMvcSite(); } }
        //public IContentService ContentService { get { return StructureMap.ObjectFactory.GetInstance<IContentService>(); } }
        //protected UserSessionManagerViewModel UserSessionManager { get { return WebSite.UserSessionManager; } }
        //protected IUserSessionManagerContext UserSessionManagerContext { get { return WebSite.UserSessionManagerContext; } }
        //public IMySceneService MySceneService { get { return ObjectFactory.GetInstance<IMySceneService>(); } }

        //public IIncludeHelper IncludeHelper
        //{
        //    get
        //    {
        //        const string key = "IncludeHelperContextKey";
        //        if (Context.Items[key] == null)
        //        {
        //            Context.Items[key] = ObjectFactory.GetInstance<IIncludeHelper>();
        //        }
        //        return (IIncludeHelper)Context.Items[key];
        //    }
        //}
    }
    //For strongly typed view
    public abstract class BaseWebViewPage<TModel> : WebViewPage<TModel>
    {
        //private IIncludeHelper _includeHelper;
        //public IMvcWebSite WebSite { get { return WebSiteAdmin.GetMvcSite(); } }
        //public IContentService ContentService { get { return ObjectFactory.GetInstance<IContentService>(); } }
        //protected UserSessionManagerViewModel UserSessionManager { get { return WebSite.UserSessionManager; } }
        //protected IUserSessionManagerContext UserSessionManagerContext { get { return WebSite.UserSessionManagerContext; } }
        //public IMySceneService MySceneService { get { return ObjectFactory.GetInstance<IMySceneService>(); } }

        //public IIncludeHelper IncludeHelper
        //{
        //    get
        //    {
        //        const string key = "IncludeHelperContextKey";
        //        if (Context.Items[key] == null)
        //        {
        //            Context.Items[key] = ObjectFactory.GetInstance<IIncludeHelper>();
        //        }
        //        return (IIncludeHelper)Context.Items[key];
        //    }
        //}
    }
}