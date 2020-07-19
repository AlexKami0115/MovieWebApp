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
            var movie = new Movie() {Name = "Shrek!" };

            return Content("Random Page");
        }

        [Route("MoviesController/Movies")]
        public ActionResult Movies()
        {
            var movies = new List<Movie>
            {
                new Movie {Name = "Movie 1"},
                new Movie {Name = "Movie 2"}
            };

            var viewModel = new MoviesViewModel
            {
                Movies = movies
            };

            return View(viewModel);

        }

        [Route("MoviesController/Customers")]
        public ActionResult Customers()
        {
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };

            var viewModel = new CustomersViewModel
            {
                Customers = customers
            };

            return View(viewModel);

        }

        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        //movies
        public ActionResult Index(int? pageindex, string sortBy)
        {
            if (!pageindex.HasValue)
                pageindex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageindex, sortBy));

        }
    }
}


//          VARIOUS RETURN EXAMPLES.
//          return Content("Hello World!");
//          return HttpNotFound();
//          return new EmptyResult();
//          return RedirectToAction("Index", "Home", new {page = 1, sortby = "name"});