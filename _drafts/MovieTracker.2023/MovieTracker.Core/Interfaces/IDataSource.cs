using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using MovieTracker.Data.Data;

namespace MovieTracker.Core.Interfaces
{
    public interface IDataSource : IDisposable
    {
        DbSet<Watchlist> Watchlists { get; }

        DbSet<WatchlistItem> WatchlistItems { get; }


        EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        int SaveChanges();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}