﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Optimization;
using System.Web.Routing;

namespace UscParser
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			GlobalConfiguration.Configure(WebApiConfig.Register);
			BundleConfig.RegisterBundles(BundleTable.Bundles);
		}
    }
}
