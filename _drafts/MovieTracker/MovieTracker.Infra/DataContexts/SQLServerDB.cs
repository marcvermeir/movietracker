using MovieTracker.Infra.Data;
using System;
using System.Data.Entity;

namespace MovieTracker.Infra.DataContexts
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
            //// modelBuilder.Entity<OrderItem>().HasKey(e => new { e.OrderID, e.OrderLine });
        }

        public DbSet<MItem> MItems => throw new NotImplementedException();
    }
}
