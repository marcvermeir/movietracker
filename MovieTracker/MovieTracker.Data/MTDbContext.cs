using Microsoft.EntityFrameworkCore;
using MovieTracker.Core.Models;

namespace MovieTracker.Data
{
    public class MTDbContext : DbContext
    {
        public MTDbContext(DbContextOptions<MTDbContext> options) : base(options) 
        { 
        }

        public DbSet<Movie> Movies { get; set; } = null!;
    }
}