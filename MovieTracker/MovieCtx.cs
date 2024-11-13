using Microsoft.EntityFrameworkCore;
using MovieTracker.Models;

namespace MovieTracker
{
    public class MovieCtx : DbContext
    {
        public MovieCtx(DbContextOptions<MovieCtx> options) : base(options) { }

        public DbSet<Movie> Movies { get; set; }
    }
}