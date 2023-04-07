using MovieTracker.Core.Domain;
using MovieTracker.Core.Repositories;
using System;
using System.Collections.Generic;

namespace MovieTracker.Infra.Respositories
{
    public class WatchlistItemRepository : Repository<WatchlistItem>, IWatchlistItemRepository
    {
        public WatchlistItemRepository(MovieTrackerContext context) : base(context) 
        { 
        }

        public IEnumerable<WatchlistItem> GetAllWatchlistItemsWithWatchlist(long id)
        {
            throw new NotImplementedException();
        }

        public MovieTrackerContext MovieTrackerContext
        {
            get { return Context as MovieTrackerContext; }
        }
    }
}