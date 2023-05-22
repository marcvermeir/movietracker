using MovieTracker.Core.Domain;
using System.Collections.Generic;

namespace MovieTracker.Core.Repositories
{
    public interface IWatchlistItemRepository : IRepository<WatchlistItem>
    {
        IEnumerable<WatchlistItem> GetAllWatchlistItemsWithWatchlist(long id);
    }
}