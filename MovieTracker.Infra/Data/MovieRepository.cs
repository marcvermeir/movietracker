using MovieTracker.Core.Interfaces;
using MovieTracker.Infra.Models.Entities;

namespace MovieTracker.Infra.Data
{
    public class MovieRepository : EfRepository<Movie>,  IMovieRepository
    {
        public MovieRepository(MovieTrackerContext dbContext) : base(dbContext)
        {
        }
    }
}
