using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MovieTracker.Models
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }
        public required string Title { get; set; }

        public int Year { get; set; }
        public long ISBN { get; set; }
        public DateTime PublishedDate { get; set; }
        public short Price { get; set; }

        public int AuthorID { get; set; }
    }

    public class BooksDB : DbContext
    {
        public BooksDB(DbContextOptions<BooksDB> options) : base(options) { }
        public DbSet<Book> Books => Set<Book>();
    }
}