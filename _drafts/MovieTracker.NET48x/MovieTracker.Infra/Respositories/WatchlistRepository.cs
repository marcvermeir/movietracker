using MovieTracker.Core.Domain;
using MovieTracker.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace MovieTracker.Infra.Respositories
{
    public class WatchlistRepository : Repository<Watchlist>, IWatchlistRepository
    {
        public WatchlistRepository(MovieTrackerContext context) : base(context) { }

        public Watchlist GetWatchlistWithWatchlistItems(long id)
        {
            return GetWatchLists()
                .Where(x => x.Id == id)
                .First();
        }

        public IEnumerable<Watchlist> GetWatchlistsWhereWithWatchlistItems(Expression<Func<Watchlist, bool>> pred)
        {
            _ = pred ?? throw new ArgumentNullException(nameof(pred));

            return GetWatchLists()
                .Where(pred)
                .ToList();
        }

        public MovieTrackerContext MovieTrackerContext
        {
            get { return Context as MovieTrackerContext; }
        }


        private IQueryable<Watchlist> GetWatchLists()
        {
            return MovieTrackerContext.Watchlists.Include(x => x.WatchlistItems);
        }
    }
}