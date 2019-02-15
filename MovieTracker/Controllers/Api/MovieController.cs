using Microsoft.AspNetCore.Mvc;
using MovieTracker.Controllers.Api;
using MovieTracker.Core.Interfaces;
using System.Threading.Tasks;

namespace MovieTracker.Controllers
{
    public class MovieController : BaseApiController
    {
        // ?? private readonly IWatchListService _watchListService;
        private readonly IMovieRepository _movieRepository;

        // ?? public MovieController(IWatchListService watchListService) => _watchListService = watchListService;
        public MovieController(IMovieRepository movieRepository) => _movieRepository = movieRepository;


        [HttpGet]
        //public IEnumerable<Movie> List(int? page)
        public async Task<IActionResult> List(int? page)
        {

            var itemsPage = 10;

            // ?? var watchListModel = await _watchListService.GetWatchListMovies(page ?? 0, itemsPage);
            var vm = _movieRepository.ListAll();

            // ?? return Ok(watchListModel);
            return Ok(vm);


            ////TODO: >> implement fetching the watchlist movies from the TMDB via it's API .. OR .. fetch them from the own database ?!
            //return new List<Movie>() {
            //    new Movie() {
            //        Homepage = "http://www.foxmovies.com/movies/fight-club", Id = 550, IMDBId = "tt0137523", OriginalLanguage = "en", OriginalTitle = "Fight Club", ReleaseDate = DateTime.Parse("1999-10-15")
            //    },
            //    new Movie() {
            //        Homepage = "http://www.foxmovies.com/movies/fight-club", Id = 551, IMDBId = "tt0137523", OriginalLanguage = "en", OriginalTitle = "Fight Club", ReleaseDate = DateTime.Parse("1999-10-15")
            //    } };

        }
    }
}

