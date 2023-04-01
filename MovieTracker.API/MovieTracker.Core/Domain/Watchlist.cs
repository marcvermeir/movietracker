using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieTracker.Core.Domain
{
    public class Watchlist
    {
        public Watchlist() 
        { 
            WatchlistItems = new HashSet<WatchlistItem>();
        }


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        [Index(IsUnique = true)]
        [MaxLength(50)]
        public string Title { get; set; }


        [Timestamp]
        public Byte[] TimeStamp { get; set; }

        public virtual ICollection<WatchlistItem> WatchlistItems { get; set; }
    }
}
