using MovieTracker.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MovieTracker.Core.Repositories
{
    public interface IWatchlistRepository : IRepository<Watchlist>
    {
        Watchlist GetWatchlistWithWatchlistItems(long id);

        IEnumerable<Watchlist> GetWatchlistsWhereWithWatchlistItems(Expression<Func<Watchlist, bool>> pred);
    }
}