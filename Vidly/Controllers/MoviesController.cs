using Microsoft.AspNetCore.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        ////GET: Movies/Random
        //public IActionResult Random()
        //{
        //    var movie = new Movie() { Name = "Vikram Vedha!" };
        //    var customers = new List<Customer>
        //    {   new Customer { Name = "John Smith"},
        //        new Customer { Name = "Mary Williams"}
        //    };

        //    var viewModel = new RandomMovieViewModel
        //    {
        //        Movie = movie,
        //        Customers = customers
        //    };

        //    //return View(movie);
        //    return View(viewModel);
        //}

        //public IActionResult Edit(int id)
        //{
        //    return Content("ID - " + id);
        //}

        //// Movies
        //public IActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;

        //    if (String.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";

        //    return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        //}

        //[HttpGet("Movies/ByReleaseDate/{year}/{month}")]  // New way to add custom route
        //public IActionResult ByReleaseDate(int year, int month)
        //{
        //    return Content(year + " " + month);
        //}

        public IActionResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie{ Id=1, Name="Vikram Vedha"},
                new Movie{ Id=2, Name="RRR"}
            };
        }

        
    }
}
