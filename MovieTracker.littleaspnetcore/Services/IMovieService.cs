using MovieTracker.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieTracker.Services
{
    public interface IMovieService
    {
        Task<IEnumerable<Movie>> GetMovies2WatchAsync();
    }
}
