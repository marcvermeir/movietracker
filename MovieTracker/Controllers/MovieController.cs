using MediatR;
using Microsoft.AspNetCore.Mvc;
using MovieTracker.Application.Movies.Commands.CreateMovie;
using MovieTracker.Domain.DTOs.Requests.Movie;

namespace MovieTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MovieController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateMovie([FromBody] CreateMovieRequest request)
        {
            var movie = await _mediator.Send(new CreateMovieCommand(
                request.Title,
                request.Description,
                request.Genre,
                (int)request.Rating,
                request.YearOfRelease,
                request.Director,
                request.Status
                ));

            return Ok(movie);
        }
    }
}