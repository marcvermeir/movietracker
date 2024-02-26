using Microsoft.AspNetCore.Mvc;
using MT.Api.Core.Domain;
using MT.Api.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace MT.Api.Api.Controllers
{
    [Route("api/v1.0/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MoviesController(IMovieService movieService) 
        { 
            _movieService = movieService ?? throw new ArgumentNullException(nameof(movieService));

        }

        [HttpGet]
        public IActionResult GetMoviesAsync()
        {
            DataRequest<Movie> request = BuildDataRequest();

            return Ok(_movieService.GetMoviesAsync(request));
        }


        private DataRequest<Movie> BuildDataRequest()
        {
            return new DataRequest<Movie>()
            {
                Query = Query,
                OrderBy = ViewModelArgs.OrderBy,
                OrderByDesc = ViewModelArgs.OrderByDesc
            };
        }
    }
}