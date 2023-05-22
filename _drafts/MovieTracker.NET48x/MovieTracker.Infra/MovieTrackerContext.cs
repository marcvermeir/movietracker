using MovieTracker.Core.Domain;
using MovieTracker.Core.Repositories;
using System;
using System.Data.Entity;
using System.Linq;
using System.Threading;

namespace MovieTracker.Infra
{
    public class MovieTrackerContext : DbContext
    {
        public MovieTrackerContext() 
            : base("name=MovieTrackerContext") 
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
            
            //TODO: >>> check/add other configuration properties ?!
        }

        public virtual DbSet<Watchlist> Watchlists { get; set; }
        public virtual DbSet<WatchlistItem> WatchlistItems { get; set; }

        public override int SaveChanges()
        {
            var modifiedEntries = ChangeTracker.Entries()
                .Where(x => x.Entity is IAuditableEntity && 
                        (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entry in modifiedEntries)
            {
                IAuditableEntity entity = entry.Entity as IAuditableEntity;
                if (entity != null)
                {
                    string identityName = Thread.CurrentPrincipal.Identity.Name;
                    DateTime now = DateTime.UtcNow;

                    if (entry.State == EntityState.Added)
                    {
                        entity.CreatedBy = identityName;
                        entity.CreatedDate = now;
                    }
                    else
                    {
                        base.Entry(entity).Property(x => x.CreatedBy).IsModified = false;
                        base.Entry(entity).Property(x => x.CreatedDate).IsModified = false;
                    }

                    entity.UpdatedBy = identityName;
                    entity.UpdatedDate = now;
                }
            }

            return base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // modelBuilder.Configurations.Add(new WatchlistConfiguration());
        }
    }
}
