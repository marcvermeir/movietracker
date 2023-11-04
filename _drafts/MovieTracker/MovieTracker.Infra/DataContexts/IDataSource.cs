using MovieTracker.Infra.Data;
using System;
using System.Data.Entity;
using System.Threading;
using System.Threading.Tasks;

namespace MovieTracker.Infra.DataContexts
{
    public interface IDataSource : IDisposable
    {
        DbSet<MItem> MItems { get; }

        //??? EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        int SaveChanges();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}
