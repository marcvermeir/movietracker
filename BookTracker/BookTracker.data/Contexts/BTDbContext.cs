using BookTracker.core.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookTracker.data.Contexts
{
    public class BTDbContext : DbContext
    {
        #region Properties

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="options">The options to use</param>
        public BTDbContext(DbContextOptions<BTDbContext> options) : base(options)
        {
        }

        #endregion

        #region Methods

        /// <summary>
        /// Allows the database model to be further configured before it is locked down.
        /// </summary>
        /// <param name="modelBuilder">The builder being used to construct the model for this context</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BTDbContext).Assembly);
        }

        #endregion

    }
}
