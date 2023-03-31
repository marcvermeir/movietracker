using MovieTracker.Core.Domain;
using MovieTracker.Infra.EntityConfigurations;
using System.Data.Entity;

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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new WatchlistConfiguration());
        }
    }
}
