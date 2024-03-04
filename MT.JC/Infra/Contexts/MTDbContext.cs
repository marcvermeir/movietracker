using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infra.Contexts
{
    public class MTDbContext : DbContext
    {
        #region Properties

        public DbSet<Watchlist> Watchlists { get; set; }

        public DbSet<MediaItem> MediaItems { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="options">The options to use</param>
        public MTDbContext(DbContextOptions<MTDbContext> options) : base(options)
        {
            //TODO: >>> disable Lazy Loading / Change Tracking / ...
        }

        #endregion

        #region Methods

        /// <summary>
        /// Allows the database model to be further configured before it is locked down.
        /// </summary>
        /// <param name="modelBuilder">The builder being used to construct the model for this context</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MTDbContext).Assembly);

            /* //TODO: 
            // Define relationship between todos and creators
            modelBuilder.Entity<Todo>()
                .HasOne(x => x.Creator)
                .WithMany(x => x.Todos);

            // Define relationship between todos and creators
            modelBuilder.Entity<Todo>()
                .HasOne(x => x.TodoList)
                .WithMany(x => x.Todos);
            */

            // Seed database with authors and books for demo
            new DbInitializer(modelBuilder).Seed();
        }

        #endregion
    }
}
