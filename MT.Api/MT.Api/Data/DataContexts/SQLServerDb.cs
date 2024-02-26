using Microsoft.EntityFrameworkCore;
using MT.Api.Core.Domain;

namespace MT.Api.Data.DataContexts
{
    public class SQLServerDb : DbContext, IDataSource
    {
        private string? _connectionString = null;

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
            //TODO: modelBuilder.Entity<OrderItem>().HasKey(e => new { e.OrderID, e.OrderLine });
        }

        public DbSet<DbVersion> DbVersion { get; set; }

        public DbSet<Movie> Movies { get; set; }
    }
}