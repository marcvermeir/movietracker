using MovieTracker.Core.Domain;
using MovieTracker.Core.Repositories;
using System;

namespace MovieTracker.Infra.Respositories
{
    public class WatchlistRepository : Repository<Watchlist>, IWatchlistRepository
    {
        public WatchlistRepository(MovieTrackerContext context) : base(context) { }

        public Watchlist GetWatchlistWithWatchlistItems(long id)
        {
            //TODO: >>>
            throw new NotImplementedException();
        }

        public MovieTrackerContext MovieTrackerContext
        {
            get { return Context as MovieTrackerContext; }
        }
    }
}