using MovieTracker.Core;
using MovieTracker.Core.Repositories;
using MovieTracker.Infra.Respositories;
using System;

namespace MovieTracker.Infra
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MovieTrackerContext _context;

        public UnitOfWork(MovieTrackerContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));

            //TODO: ??? quid using DI (Autofac ?!) ???
            Watchlists = new WatchlistRepository(_context);
            WatchlistItems = new WatchlistItemRepository(_context);
        }

        public IWatchlistRepository Watchlists          { get; private set; }

        public IWatchlistItemRepository WatchlistItems  { get; private set; }

        public long Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
