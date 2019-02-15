using MovieTracker.Core.Entities;

namespace MovieTracker.Core.Interfaces
{
    public interface IMovieRepository : IRepository<Movie>, IAsyncRepository<Movie>
    {
        //TODO: ?! ..
        // Order GetByIdWithItems(int id);
        // Task<Order> GetByIdWithItemsAsync(int id);
    }
}
