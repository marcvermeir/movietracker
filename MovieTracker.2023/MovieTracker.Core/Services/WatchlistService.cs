using MovieTracker.Core.Common;
using MovieTracker.Core.DTOs;
using MovieTracker.Core.Interfaces;
using MovieTracker.Data.Data;

namespace MovieTracker.Core.Services
{
    public class WatchlistService : IWatchlistService
    {
        public IDataServiceFactory DataServiceFactory { get; }

        public WatchlistService(IDataServiceFactory dataServiceFactory) 
        {
            DataServiceFactory = dataServiceFactory;
        }


        public Task<IList<WatchlistDTO>> GetWatchlistsAsync(int skip, int take, DataRequest<Watchlist> request)
        {
            throw new NotImplementedException();
        }
    }
}