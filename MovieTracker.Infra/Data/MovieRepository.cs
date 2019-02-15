using MovieTracker.Core.Entities;
using MovieTracker.Core.Interfaces;

namespace MovieTracker.Infra.Data
{
    public class MovieRepository : EfRepository<Movie>,  IMovieRepository
    {
        public MovieRepository(MovieTrackerContext dbContext) : base(dbContext)
        {
            //todo: add some other methods ?! ..
        }
    }
}
