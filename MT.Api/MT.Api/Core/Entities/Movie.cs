using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    [Table("Movies")]
    public class Movie
    {
        public Movie() { }

        [Key]
        public int Id { get; set; }

        public required string Title { get; set; }

        public string? Description { get; set; }

        public required string Director { get; set; }

        public DateOnly YearOfRelease { get; set; }

        public string? IMDBRef { get; set; }

        public string BuildSearchTerms() => $"{Id} {Title} {Description} {Director} {YearOfRelease}".ToLower();
    }
}