using MovieTracker.Core.Domain;
using MovieTracker.Core.Repositories;
using System.Data.Entity;
using System.Linq;

namespace MovieTracker.Infra.Respositories
{
    public class WatchlistRepository : Repository<Watchlist>, IWatchlistRepository
    {
        public WatchlistRepository(MovieTrackerContext context) : base(context) { }

        public Watchlist GetWatchlistWithWatchlistItems(long id)
        {
            return MovieTrackerContext.Watchlists
                .Include(x => x.WatchlistItems)
                .Where(x => x.Id == id)
                .First();
        }

        public MovieTrackerContext MovieTrackerContext
        {
            get { return Context as MovieTrackerContext; }
        }
    }
}