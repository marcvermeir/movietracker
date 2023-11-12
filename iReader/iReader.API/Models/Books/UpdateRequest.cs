using System.ComponentModel.DataAnnotations;

namespace iReader.API.Models.Books
{
    public class UpdateRequest
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string Author { get; set; }

        public string Language { get; set; }

        public string Genre { get; set; }
    }
}