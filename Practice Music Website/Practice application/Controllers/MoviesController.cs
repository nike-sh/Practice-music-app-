using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practice_application.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Overview()
        {
            ViewBag.Message = "Movies.";

            return View();
        }
        public ActionResult TopMovies()
        {
            ViewBag.Message = "Movies.";

            return View();
        }
       
        public ActionResult AnimatedMovies()
        {
            ViewBag.Message = "Movies.";

            return View();
        }
        public ActionResult EditorsPicksmovies()
        {
            ViewBag.Message = "Movies.";

            return View();
        }
    }
}