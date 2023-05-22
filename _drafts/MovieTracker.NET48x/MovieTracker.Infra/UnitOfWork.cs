using MovieTracker.Core;
using MovieTracker.Core.Repositories;
using MovieTracker.Infra.Respositories;
using System;

namespace MovieTracker.Infra
{
    public class UnitOfWork : IUnitOfWork
    {
        private MovieTrackerContext _context;

        public UnitOfWork(MovieTrackerContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));

            Watchlists = new WatchlistRepository(_context);

            WatchlistItems = new WatchlistItemRepository(_context);
        }

        public IWatchlistRepository Watchlists          { get; private set; }

        public IWatchlistItemRepository WatchlistItems  { get; private set; }

        public long Complete()
        {
            return _context.SaveChanges();
        }

        /*
        public void Dispose()
        {
            _context.Dispose();
        }
        */

        /// <summary>
        /// Disposes the current object
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        /// <summary>
        /// Disposes all external resources.
        /// </summary>
        /// <param name="disposing">The dispose indicator.</param>
        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_context != null)
                {
                    _context.Dispose();
                    _context = null;
                }
            }
        }
    }
}