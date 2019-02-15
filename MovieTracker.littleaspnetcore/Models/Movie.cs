using System;

namespace MovieTracker.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime? YearOfRelease { get; set; }

        public string WatchPriority { get; set; }
    }
}
