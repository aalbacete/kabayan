using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CaptchaMvc.HtmlHelpers;
using Kabayan.BusinessRepository;
using Kabayan.Domain.Models;

namespace Kabayan.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
           // var bll = new WebCmsBusinessRepository();
           // var a = bll.ContactUsLogs;
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
     
        [HttpPost]
        public ActionResult SendInquiry(MessageLog messageLog)
        {
            
            if (!ModelState.IsValid) return View("ContactUs");

            if (this.IsCaptchaValid("Captcha is not valid"))
            {
                TempData["Message"] = "Message: captcha is valid.";
                return View("ContactUs"); 
            }

            TempData["ErrorMessage"] = "Error: captcha is not valid.";
            //TODO: Save first to database before sending to email

            //TODO: Send to recipient
            return View();
        }
    }
}