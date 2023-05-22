using Microsoft.EntityFrameworkCore;
using MovieTracker.Core.Interfaces;
using MovieTracker.Data.Data;

namespace MovieTracker.Data.DB
{
    public class SQLServerDb : DbContext, IDataSource
    {
        private string _connectionString = null;

        public SQLServerDb(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<OrderItem>().HasKey(e => new { e.OrderID, e.OrderLine });
        }

        public DbSet<Watchlist> Watchlists { get; set; }

        public DbSet<WatchlistItem> WatchlistItems { get; set; }
    }
}