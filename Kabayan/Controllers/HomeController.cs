using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kabayan.BusinessRepository;
namespace Kabayan.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var bll = new WebCmsBusinessRepository();
            var a = bll.ContactUsLogs;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Faq()
        {
            ViewBag.Message = "FAQs";
            return View();
        }

        public ActionResult Coverage()
        {
            ViewBag.Message = "Coverage";
            return View();
        }

        public ActionResult Rates()
        {
            return View();
        }
        public ActionResult ContactUs()
        {
            return View();
        }
        [Route("Agent/Login")]
        public ActionResult Agent()
        {
            return View();
        }
    }
}