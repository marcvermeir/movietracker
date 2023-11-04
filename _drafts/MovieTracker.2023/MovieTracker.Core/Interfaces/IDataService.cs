using MovieTracker.Core.Common;
using MovieTracker.Data.Data;

namespace MovieTracker.Core.Interfaces
{
    public interface IDataService : IDisposable
    {
        Task<Watchlist> GetWatchlistAsync(long id);
        Task<IList<Watchlist>> GetWatchlistsAsync(int skip, int take, DataRequest<Watchlist> request);

        Task<IList<WatchlistItem>> GetWatchlistItemsAsync(int skip, int take, DataRequest<WatchlistItem> request);
    }
}