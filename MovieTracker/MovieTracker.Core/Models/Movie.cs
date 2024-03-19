using MovieTracker.Core.Interfaces;

namespace MovieTracker.Core.Models
{
    public class Movie : IEntity
    {
        public long ID { get; }

        public string? Title { get; set; }

        public string? Genre { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string? Director { get; set; }

        public DateTime DateSeen { get; set; }

        
        //TODO: public PriorityEnum Priority
    }
}