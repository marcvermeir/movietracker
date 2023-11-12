using System.ComponentModel.DataAnnotations;

namespace iReader.API.Models.Books
{
    public class CreateRequest
    {
        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        public string Author { get; set; }

        public string Language { get; set; }

        public string Genre { get; set; }
    }
}