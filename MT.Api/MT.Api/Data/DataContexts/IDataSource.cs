using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using MT.Api.Core.Domain;

namespace MT.Api.Data
{
    public interface IDataSource : IDisposable
    {
        DbSet<DbVersion> DbVersion { get; }

        DbSet<Movie> Movies { get; }

        EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        int SaveChanges();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}