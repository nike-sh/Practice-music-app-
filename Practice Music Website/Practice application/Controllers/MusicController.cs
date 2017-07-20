using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practice_application.Controllers
{
    public class MusicController : Controller
    {
        // GET: Music
        public ActionResult Overview()
        {
            ViewBag.Message = "Music.";

            return View();
        }

        public ActionResult Top10()
        {
            ViewBag.Message = "Music.";

            return View();
        }

        public ActionResult LatestReleases()
        {
            ViewBag.Message = "Music.";

            return View();
        }
        public ActionResult EditorsPicksMusic()
        {
            ViewBag.Message = "Music.";

            return View();
        }

    }
}