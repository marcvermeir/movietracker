namespace MT.Api.Core.Domain
{
    public class Movie
    {
        public Movie() { }

        public int Id { get; set; }

        public required string Title { get; set; }        

        public string? Description { get; set; }

        public required string Director { get; set; }  

        public DateOnly YearOfRelease { get; set; }
        
        public string? IMDBRef { get; set; }
    }
}