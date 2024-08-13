using CodeFirstApplication.Models;
using CodeFirstApplication.Services;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstApplication.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMovieService _movieService;

        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        public IActionResult Index()
        {
            var movies = _movieService.GetMovies();
            return View(movies);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]        
        public IActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            { 
                _movieService.AddMovie(movie); 
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Details(int id) 
        { 
            var movie = _movieService.GetMovieById(id);
            return View(movie);
        }

        public IActionResult LatestByMovics()
        {
            var movies = _movieService.GetMoviesByLeatest();
            return View(movies);
        }
        public IActionResult OlderstFiveMovies()
        {
            var movies = _movieService.GetMoviesByOldest().Take(5);
            return View(movies);
        }
    }
}
