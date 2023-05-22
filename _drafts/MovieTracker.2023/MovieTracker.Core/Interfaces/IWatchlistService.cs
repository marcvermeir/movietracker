using MovieTracker.Core.Common;
using MovieTracker.Core.DTOs;
using MovieTracker.Data.Data;

namespace MovieTracker.Core.Interfaces
{
    public interface IWatchlistService
    {
        Task<IList<WatchlistDTO>> GetWatchlistsAsync(int skip, int take, DataRequest<Watchlist> request);
    }
}