using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie();

            var movies = new List<Models.Movie>
            {
                new Models.Movie { Name = "Gladiator"},
                new Models.Movie { Name = "Looking for something"}
            };



            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Movies = movies
            };

            return View(viewModel);
        }

        //    public ActionResult Edit(int id)
        //    {

        //        return Content("id=" + id);

        //    }

        //    // Movies
        //    public ActionResult Index(int? pageIndex, string sortBy)
        //    {
        //        if (!pageIndex.HasValue)
        //            pageIndex = 1;

        //        if (string.IsNullOrWhiteSpace(sortBy))
        //            sortBy = "Name";

        //        return Content(String.Format("pageIndex={0}&sort={1}", pageIndex, sortBy));
        //    }

        //    public ActionResult ByReleaseDate(int year, int month)
        //    {
        //        return Content(year + "/" + month);
        //    }


        //}
    }
}