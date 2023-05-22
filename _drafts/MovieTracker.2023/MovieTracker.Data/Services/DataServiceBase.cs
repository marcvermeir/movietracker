using MovieTracker.Core.Common;
using MovieTracker.Core.Interfaces;
using MovieTracker.Data.Data;

namespace MovieTracker.Data.Services
{
    abstract public partial class DataServiceBase : IDataService, IDisposable
    {
        private IDataSource _dataSource = null;

        public DataServiceBase(IDataSource dataSource)
        {
            _dataSource = dataSource;
        }

        #region Watchlist

        Task<Watchlist> IDataService.GetWatchlistAsync(long id)
        {
            throw new NotImplementedException();
        }

        Task<IList<WatchlistItem>> IDataService.GetWatchlistItemsAsync(int skip, int take, DataRequest<WatchlistItem> request)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region WatchlistItem

        Task<IList<Watchlist>> IDataService.GetWatchlistsAsync(int skip, int take, DataRequest<Watchlist> request)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Dispose

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_dataSource != null)
                {
                    _dataSource.Dispose();
                }
            }
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}