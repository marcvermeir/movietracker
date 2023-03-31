using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieTracker.Core.Domain
{
    public class Watchlist
    {
        public Watchlist() 
        { 
            WatchlistItems = new HashSet<WatchlistItem>();
        }

        [Key]
        public long Id { get; set; }

        public string Title { get; set; }

        public virtual ICollection<WatchlistItem> WatchlistItems { get; set; }
    }
}
