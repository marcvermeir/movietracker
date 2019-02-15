using MovieTracker.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieTracker.Services
{
    public class FakeMovieService : IMovieService
    {
        public Task<IEnumerable<Movie>> GetMovies2WatchAsync()
        {
            IEnumerable<Movie> movies = new[] {
                new Movie { Id = 1, Title = "BladeRunner", WatchPriority = "1000", YearOfRelease = DateTime.Now },
                new Movie { Id = 2, Title = "Gladiator", WatchPriority = "1000", YearOfRelease = DateTime.Now }
            };

            return Task.FromResult(movies);
        }
    }
}
