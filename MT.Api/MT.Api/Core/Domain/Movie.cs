using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mail;

namespace MT.Api.Core.Domain
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

        public string BuildSearchTerms() => $"{Id}0 {Title} {Description} {Director} {YearOfRelease}".ToLower();
    }
}