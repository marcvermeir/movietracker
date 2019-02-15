using Microsoft.EntityFrameworkCore;
using MovieTracker.Core.Entities;

namespace MovieTracker.Infra.Data
{
    public partial class MovieTrackerContext : DbContext
    {
        public MovieTrackerContext()
        {
        }

        public MovieTrackerContext(DbContextOptions<MovieTrackerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Movie> Movie { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MovieTracker;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.1-servicing-10028");

            modelBuilder.Entity<Movie>(entity =>
            {
                entity.ToTable("movie");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.WatchPriority)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.YearOfRelease).HasColumnType("date");
            });
        }
    }
}
