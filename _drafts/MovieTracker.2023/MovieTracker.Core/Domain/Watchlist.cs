using MovieTracker.Core.Common;
using System.ComponentModel.DataAnnotations;

namespace MovieTracker.Data.Data
{
    public partial class Watchlist : AuditableEntity<long>
    {
        //public Watchlist()
        //{
        //    WatchlistItems = new HashSet<WatchlistItem>();
        //}


        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public long Id { get; set; }


        [Required]
        //??? [Index(IsUnique = true)]
        [MaxLength(50)]
        public string? Title { get; set; }


        [Timestamp]
        public Byte[]? TimeStamp { get; set; }

        public virtual ICollection<WatchlistItem>? WatchlistItems { get; set; }
    }
}
