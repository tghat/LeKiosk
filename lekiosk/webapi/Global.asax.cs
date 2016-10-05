using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using webapi.App_Start;

namespace webapi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            MappingConfig.RegisterModelToViewModelMapping();
            MappingConfig.RegisterViewModelToModelMapping();
        }
    }
}
