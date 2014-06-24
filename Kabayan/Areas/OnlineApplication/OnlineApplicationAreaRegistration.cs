using System.Web.Mvc;

namespace Kabayan.Areas.OnlineApplication
{
    public class OnlineApplicationAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "OnlineApplication";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "OnlineApplication_default",
                "OnlineApplication/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}