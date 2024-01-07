using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infra.Contexts
{
    public class AppDbContext : DbContext
    {
        #region Properties

        //public DbSet<Todo> Todos { get; set; }
        //public DbSet<User> Users { get; set; }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="options">The options to use</param>
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
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
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

            // Define relationship between books and authors
            modelBuilder.Entity<Book>()
                .HasOne(x => x.Author)
                .WithMany(x => x.Books);

            // Seed database with authors and books for demo
            new DbInitializer(modelBuilder).Seed();
        }

        #endregion
    }
}
