using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieTracker.Core.Domain
{
    public class WatchlistItem
    {
        [Key]
        public long Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Watchlist> Watchlists { get; set; }
    }
}
