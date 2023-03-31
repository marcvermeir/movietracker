using MovieTracker.Core.Repositories;
using System;

namespace MovieTracker.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IWatchlistRepository Watchlists { get; }
        IWatchlistItemRepository WatchlistItems { get; }
        long Complete();
    }
}