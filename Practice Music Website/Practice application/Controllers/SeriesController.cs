using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practice_application.Controllers
{
    public class SeriesController : Controller
    {
        // GET: 
        public ActionResult Overview()
        {
            ViewBag.Message = "Series.";

            return View();
        }
        public ActionResult TV()
        {
            ViewBag.Message = "Series.";

            return View();
        }
        public ActionResult Animated()
        {
            ViewBag.Message = "Series.";

            return View();
        }


        public ActionResult EditorsPicksSeries()
        {
            ViewBag.Message = "Series.";

            return View();
        }
    }
}