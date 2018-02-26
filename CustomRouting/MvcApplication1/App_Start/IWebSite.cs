using System;
using System.Web;

namespace MvcApplication1.App_Start
{
     public interface IWebSite : IWebRequestHandler
    {
       // SiteConfiguration Configuration { get; }
        string OverrideConfigPath { get; }
        System.Configuration.ConnectionStringSettingsCollection ConnectionStrings { get; }
        string CurrentApplicationPath { get; }
        string CurrentHost { get; }
        string CurrentDomain { get; }
        string CurrentSiteUrl { get; }
        string CurrentRequestPath { get; }
        string GetCurrentApplicationPath(HttpContext context);
        string GetCurrentHost(HttpContext context);
        string GetCurrentSiteUrl(HttpContext context);
        bool IsSecureConnectionRequired { get; }
        bool RequireSecureConnection();
        bool RequireUnsecureConnection();
        void SetNoClientCaching();
        bool RequireRole(HttpContext context, string commaSeperatedRoleNames);
        bool RequireSignIn(HttpContext context);
        string SecureSiteUrl { get; }
       // WebServerSiteInfo ServerInfo { get; }
        string SiteId { get; }
        string CurrentAppLayerUrl { get; }
        string UnsecureSiteUrl { get; }
        string CurrentRootUrl { get; }
        string SecureRootUrl { get; }
        string UnsecureRootUrl { get; }
        //IUrlBuilder UrlBuilder { get; }
        //IOnlineStore Store { get; }
        //IImageServerConfiguration ImageServer { get; }
        //ISiteTrackingSettings SiteTracking { get; }
        //string SiteName { get; }
        string SiteTitle { get; }
        string SiteVersionHtml { get; }
        Version SiteVersion { get; }
        //IWebServerUtil ServerUtil { get; }
        //ApplicationServerType ServerType { get; }
      //  void ApplicationInit(WebSiteApplication app);
        void Init();
      //  DynamicPath TranslatePath(string path, HttpContext context);
        void ClearPathCache();
       // void AddRouteForExtenstion(DynamicRoute route);
      //  DynamicRoute RemoveRoute(string action);
       // void AddRoute(DynamicRoute route);
       // DynamicRoute RemoveRouteForExtenstion(string extension);
        void ClearRoutes();
      //  List<DynamicRoute> DynamicRoutes { get; }
        int CurrentPort { get; }
        string CurrentHostAndPort { get; }
        string CurrentUrlScheme { get; }
        Guid InstanceId { get; }
        DateTime Created { get; }
        bool IsSecure { get; }
        string CustomerServiceProductionHostName { get; }
        string ProductionHostName { get; }
        string PreProductionHostName { get; }
        string SecureProductionHostName { get; }
        //DynamicRoute ForAction(string action);
        //DynamicRoute ForExtension(string extension);
        //DynamicRoute ForFileName(string fileName);
        //DynamicRoute ForProductAction();
        //DynamicRoute ForItemAction();
        //DynamicRoute ForRegEx(string strRegEx);
        //SessionState GetSessionState(HttpContext context);
        //SessionState GetNewSessionState(HttpContext context);
        
        //IWebSiteSecurity GetSecurity(HttpContext context);
        string GetConfigValue(string key);
        string GetConfigValue(string key, string defaultValue);
        int GetConfigValueAsInt(string key, int defaultValue);
        void RedirectToServerErrorPage(HttpResponse response);
        void RedirectPageNotFound(HttpContext context);
        void RedirectPageNotFound(HttpResponse response, string path);
        //DeploymentEnvironment DeploymentEnvironment { get; }
        string ContactAddress { get; }
        string CookieDomain { get; }

        void SetCookie(string strCookieName, string strCookieValue);
        void SetCookie(string strCookieName, string strCookieValue, DateTime? dtExpiration);
        //void SetCookieValues(string strCookieName, NameValueCollection colValues);
        void SetCookie(string cookieName, string cookieValue, bool encryptCookie);
        void SetCookie(string cookieName, string cookieValue, DateTime? expiration, bool encryptCookie);
        //void SetCookie(string cookieName, string cookieValue, DateTime? expiration, CipherMode cipherMode);
        //void SetCookie(string cookieName, NameValueCollection cookieValues, DateTime? expiration, bool encryptCookie);
        //void SetCookie(string cookieName, NameValueCollection cookieValues, DateTime? expiration, CipherMode cipherMode);

        bool IsCookieExists(string strCookieName);
        string GetCookie(string strCookieName);
        string GetCookie(string cookieName, bool isEncrypted);
        //string GetCookie(string cookieName, CipherMode cipherMode);
        //NameValueCollection GetCookieValues(string strCookieName);
        //NameValueCollection GetCookieValues(string cookieName, bool isEncrypted);
        //NameValueCollection GetCookieValues(string cookieName, CipherMode cipherMode);

        void RemoveCookie(string strCookieName);

        void SetCookie(string strCookieName, string strCookieValue, Guid userSessionId);
        string GetCookie(string strCookieName, Guid userSessionId);
        void RemoveCookie(string strCookieName, Guid userSessionId);

        bool RequireDevMode(HttpContext context);
        bool AllowVideo { get; }
        string VideoURL { get; }
        //AttributeFilter AttributeFilters { get; }
        //SessionState CurrentSession { get; }
        string CustomerServicePreProductionHostName { get; }
        //bool RequireAction(BasePage page, string action);
        //void OnPageIniting(BasePage page, EventArgs e);
        //void OnMasterPageIniting(BaseMasterPage page, EventArgs e);
        bool VerifyUrl(HttpContext context);

        /// <summary>
        /// determine if referrer contains given host
        /// </summary>
        /// <param name="referrer">Request.UrlReferrer</param>
        /// <param name="host">HOST name</param>
        /// <returns>true or false</returns>
        /// <example>var fromLampsPlus = website.IsFromHost(Request.UrlReferrer, "lampsplus.com");</example>
        bool ReferrerContainsHost(Uri referrer, string host);

        string ThemeName { get; }
        string EnvironmentMarkerFile { get; }
       // ExpandablePath ForRootPath(string path);
        string ExpandPath(string appRootPath, string appRelativePath);
        string GetCurrentUsersEmailAddress(HttpRequest itmRequest);
        bool IsProfessional { get; }
        bool IsSpecialMember { get; }
        bool IsEligibleForSpecialMemberPrice { get; }
        bool IsKiosk { get; }
        int KioskStoreNumber { get; }
        string ContactPhoneNumber { get; }
        string CustomerServiceSalesEmail { get; }
        string CurrencySign { get; }
       // IPresentationUtil PresentationUtil { get; }
        string DesktopSiteUrl { get; }

        //IRecommendedItemsConfiguration RecommendedItemsConfiguration { get; }
        //UserSessionManagerViewModel UserSessionManager { get; }
        //IUserSessionManagerContext UserSessionManagerContext { get; }

        //WebsiteMode CurrentMode { get; }
        //IContent Content { get; }
        void SetCanadaInSession(bool isCanadaInSession);
        bool CanShowWelcomeMatForCanadaUser { get; }
    //    // Moved from IMvcWebSite
    //    IUserContext UserContext { get; }
    //    PriceParams PriceParams { get; }
    //    SubLocation CurrentSubLocation { get; }
    //}
}
}
