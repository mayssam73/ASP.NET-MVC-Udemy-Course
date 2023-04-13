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

            // Do not use this!
            //ViewData["Movie"] = movie;
            //return View();
            
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

        //Do localhost/movies/edit/id=1 to get to this page in the browser
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        // If pageIndex not specified, movies are displayed on page 1
        // If sortBy not specified, movies are sorted by name
        // ? makes it nullable aka optional
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }


            // Prints out "pageIndex=1&sortBy=Name"
            return Content(String.Format("pageIndex={0}$sortBy={1}", pageIndex, sortBy));
        }

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + " / " + month);
        }

        // Rest of attribute route!
        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1, 12)}")]
        public ActionResult ByReleaseYear(int year, int month)
        {
            return Content(year + " / " + month);
        }
    }
}