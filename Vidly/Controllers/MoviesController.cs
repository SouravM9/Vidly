using Microsoft.AspNetCore.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using System.Data.Entity;  // For Include function

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

        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public IActionResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return _context.Movies.Include(c => c.Genre).ToList();
            
        }

        public IActionResult Details(int Id)
        {
            var movies = GetMovies();

            foreach (var movie in movies)
            {
                if (movie.Id == Id)
                    return View(movie);
            }
            return NotFound();
        }
        
    }
}
