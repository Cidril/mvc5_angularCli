using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using System.Web.Routing;
using Pv_Inf.Common.DAL;

namespace Pv_Inf
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            PvContext.Init();

            GlobalConfiguration.Configure(WebApiConfig.Register);
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
