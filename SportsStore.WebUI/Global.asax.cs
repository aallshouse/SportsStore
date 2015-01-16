using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using HibernatingRhinos.Profiler.Appender.EntityFramework;

namespace SportsStore.WebUI
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            EntityFrameworkProfiler.Initialize();
        }
    }
}
