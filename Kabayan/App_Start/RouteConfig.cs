using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Kabayan
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute("Captcha", "DefaultCaptcha/Generate", new { controller = "DefaultCaptcha", action = "Generate" });

            routes.MapRoute("CaptchaRefresh", "DefaultCaptcha/Refresh", new { controller = "DefaultCaptcha", action = "Refresh" });
            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "Default",
                url: "{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
          
        }
    }
}
