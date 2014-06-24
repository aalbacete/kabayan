using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kabayan.Areas.OnlineApplication.Controllers
{
    public class ApplyController : Controller
    {
        //
        // GET: /OnlineApplication/Apply/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /OnlineApplication/Apply/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /OnlineApplication/Apply/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /OnlineApplication/Apply/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /OnlineApplication/Apply/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /OnlineApplication/Apply/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /OnlineApplication/Apply/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /OnlineApplication/Apply/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
