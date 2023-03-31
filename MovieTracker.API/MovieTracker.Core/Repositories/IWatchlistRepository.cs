using MovieTracker.Core.Domain;

namespace MovieTracker.Core.Repositories
{
    public interface IWatchlistRepository : IRepository<Watchlist>
    {
        Watchlist GetWatchlistWithWatchlistItems(long id);
    }
}