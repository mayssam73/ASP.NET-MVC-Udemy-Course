using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        // Should set this as ViewResult instead of ActionResult, since it's just returning a view
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            return View(movie);
            // Can alternatively do
            // return ViewResult();
            // Other return types
            // return Content("Hello World!")
            // return HttpNotFound()
            // return new EmptyResult()
            // For the following, the first parameter is the action, the second is the controller, and the third is the action to redirect to
            // return RedirectToAction("Index", "Home". new { page = 1, sortBy = "name" });
        }
    }
}