using Microsoft.AspNetCore.Mvc;
using MovieTracker.Models;
using MovieTracker.Services;
using System.Threading.Tasks;

namespace MovieTracker.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        public async Task<IActionResult> Index()
        {
            // get movies from db
            var movies = await _movieService.GetMovies2WatchAsync();

            // put movies into model
            var vm = new MovieViewModel()
            {
                Movies = movies
            };

            // pass the model to a view and render
            return View(vm);
        }
    }
}