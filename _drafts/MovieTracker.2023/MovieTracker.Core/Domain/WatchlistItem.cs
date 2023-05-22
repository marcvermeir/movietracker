using MovieTracker.Core.Common;
using System.ComponentModel.DataAnnotations;

namespace MovieTracker.Data.Data
{
    public class WatchlistItem : AuditableEntity<long>
    {
        //public WatchlistItem()
        //{
        //    Watchlists = new HashSet<Watchlist>();
        //}


        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public long Id { get; set; }


        [Required]
        [MaxLength(50)]
        //??? [Index(IsUnique = true)]
        public string? Title { get; set; }

        public string? Description { get; set; }


        [Timestamp]
        public Byte[]? TimeStamp { get; set; }

        public virtual ICollection<Watchlist>? Watchlists { get; set; }
    }
}
