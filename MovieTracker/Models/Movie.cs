namespace MovieTracker.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public required string Title { get; set; }

        public DateOnly YearOfRelease { get; set; }

        public string? Director {  get; set; }

        public string? Status { get; set; }
    }
}